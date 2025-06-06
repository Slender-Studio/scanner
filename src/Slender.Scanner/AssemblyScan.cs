using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Slender.Scanner
{

    /// <summary>
    /// Represents a scanned <see cref="Assembly"/>.
    /// </summary>
    public class AssemblyScan : IAssemblyScan
    {

        #region - - - - - - Constructors - - - - - -

        private AssemblyScan() { }

        #endregion Constructors

        #region - - - - - - Properties - - - - - -

        /// <summary>
        /// The types defined in the scanned <see cref="Assembly"/>.
        /// </summary>
        public Type[] Types { get; private set; } = Array.Empty<Type>();

        #endregion Properties

        #region - - - - - - Methods - - - - - -

        /// <summary>
        /// Adds the types from the specified <paramref name="assemblies"/> to this <see cref="AssemblyScan"/>.
        /// </summary>
        /// <param name="assemblies">The assemblies to get the types from.</param>
        /// <returns>Itself.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="assemblies"/> is null.</exception>
        public AssemblyScan AddAssemblies(IEnumerable<Assembly> assemblies)
            => this.AddAssemblyScan(
                new AssemblyScan
                {
                    Types
                        = (assemblies ?? throw new ArgumentNullException(nameof(assemblies)))
                            .Where(a => a != null)
                            .SelectMany(a => a.GetTypes())
                            .ToArray()
                });

        /// <summary>
        /// Adds the types from the specified assemblies to this <see cref="AssemblyScan"/>.
        /// </summary>
        /// <param name="assembly">An <see cref="Assembly"/> to get types from.</param>
        /// <param name="additionalAssemblies">Additional assemblies to get types from.</param>
        /// <returns>Itself.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="assembly"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="additionalAssemblies"/> is null.</exception>
        public AssemblyScan AddAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => this.AddAssemblies(
                new[] { assembly ?? throw new ArgumentNullException(nameof(assembly)) }
                    .Union(additionalAssemblies ?? throw new ArgumentNullException(nameof(additionalAssemblies))));

        /// <summary>
        /// Adds the types from the specified <paramref name="assembly"/> to this <see cref="AssemblyScan"/>.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> to get types from.</param>
        /// <returns>Itself.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="assembly"/> is null.</exception>
        public AssemblyScan AddAssembly(Assembly assembly)
            => this.AddAssemblies(assembly ?? throw new ArgumentNullException(nameof(assembly)));

        /// <summary>
        /// Adds the types from the specified <paramref name="assemblyScan"/> to this <see cref="AssemblyScan"/>.
        /// </summary>
        /// <param name="assemblyScan">The <see cref="AssemblyScan"/> to get types from.</param>
        /// <returns>Itself.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="assemblyScan"/> is null.</exception>
        public AssemblyScan AddAssemblyScan(IAssemblyScan assemblyScan)
        {
            this.Types = this.Types.Union((assemblyScan ?? throw new ArgumentNullException(nameof(assemblyScan))).Types).ToArray();

            return this;
        }

        /// <summary>
        /// Gets an <see cref="AssemblyScan"/> with no types.
        /// </summary>
        /// <returns>An empty <see cref="AssemblyScan"/>.</returns>
        public static AssemblyScan Empty()
            => new AssemblyScan();

        /// <summary>
        /// Gets an <see cref="AssemblyScan"/> with types from the specified <paramref name="assemblies"/>.
        /// </summary>
        /// <param name="assemblies">The assemblies to get the types from.</param>
        /// <returns>A populated <see cref="AssemblyScan"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="assemblies"/> is null.</exception>
        public static AssemblyScan FromAssemblies(IEnumerable<Assembly> assemblies)
            => new AssemblyScan().AddAssemblies(assemblies ?? throw new ArgumentNullException(nameof(assemblies)));

        /// <summary>
        /// Gets an <see cref="AssemblyScan"/> with types from the specified assemblies.
        /// </summary>
        /// <param name="assembly">An <see cref="Assembly"/> to get types from.</param>
        /// <param name="additionalAssemblies">Additional assemblies to get types from.</param>
        /// <returns>A populated <see cref="AssemblyScan"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="assembly"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="additionalAssemblies"/> is null.</exception>
        public static AssemblyScan FromAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => new AssemblyScan().AddAssemblies(
                assembly ?? throw new ArgumentNullException(nameof(assembly)),
                additionalAssemblies ?? throw new ArgumentNullException(nameof(additionalAssemblies)));

        /// <summary>
        /// Gets an <see cref="AssemblyScan"/> with types from the specified <paramref name="assembly"/>.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> to get types from.</param>
        /// <returns>A populated <see cref="AssemblyScan"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="assembly"/> is null.</exception>
        public static AssemblyScan FromAssembly(Assembly assembly)
            => new AssemblyScan().AddAssembly(assembly ?? throw new ArgumentNullException(nameof(assembly)));

        #endregion Methods

    }

}
