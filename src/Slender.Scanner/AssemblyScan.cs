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
        public AssemblyScan AddAssemblies(IEnumerable<Assembly> assemblies)
            => this.AddAssemblyScan(new AssemblyScan { Types = assemblies.SelectMany(a => a.GetTypes()).ToArray() });

        /// <summary>
        /// Adds the types from the specified assemblies to this <see cref="AssemblyScan"/>.
        /// </summary>
        /// <param name="assembly">An <see cref="Assembly"/> to get types from.</param>
        /// <param name="additionalAssemblies">Additional assemblies to get types from.</param>
        /// <returns>Itself.</returns>
        public AssemblyScan AddAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => this.AddAssemblies(new[] { assembly }.Union(additionalAssemblies));

        /// <summary>
        /// Adds the types from the specified <paramref name="assembly"/> to this <see cref="AssemblyScan"/>.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> to get types from.</param>
        /// <returns>Itself.</returns>
        public AssemblyScan AddAssembly(Assembly assembly)
            => this.AddAssemblies(assembly);

        /// <summary>
        /// Adds the types from the specified <paramref name="assemblyScan"/> to this <see cref="AssemblyScan"/>.
        /// </summary>
        /// <param name="assemblyScan">The <see cref="AssemblyScan"/> to get types from.</param>
        /// <returns>Itself.</returns>
        public AssemblyScan AddAssemblyScan(IAssemblyScan assemblyScan)
        {
            this.Types = this.Types.Union(assemblyScan.Types).ToArray();

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
        public static AssemblyScan FromAssemblies(IEnumerable<Assembly> assemblies)
            => new AssemblyScan().AddAssemblies(assemblies);

        /// <summary>
        /// Gets an <see cref="AssemblyScan"/> with types from the specified assemblies.
        /// </summary>
        /// <param name="assembly">An <see cref="Assembly"/> to get types from.</param>
        /// <param name="additionalAssemblies">Additional assemblies to get types from.</param>
        /// <returns>A populated <see cref="AssemblyScan"/>.</returns>
        public static AssemblyScan FromAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => new AssemblyScan().AddAssemblies(assembly, additionalAssemblies);

        /// <summary>
        /// Gets an <see cref="AssemblyScan"/> with types from the specified <paramref name="assembly"/>.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> to get types from.</param>
        /// <returns>A populated <see cref="AssemblyScan"/>.</returns>
        public static AssemblyScan FromAssembly(Assembly assembly)
            => new AssemblyScan().AddAssembly(assembly);

        #endregion Methods

    }

}
