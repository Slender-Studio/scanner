using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Slender.AssemblyScanner
{

    public class AssemblyScan : IAssemblyScan
    {

        #region - - - - - - Constructors - - - - - -

        private AssemblyScan() { }

        #endregion Constructors

        #region - - - - - - Properties - - - - - -

        public Type[] Types { get; private set; } = Array.Empty<Type>();

        #endregion Properties

        #region - - - - - - Methods - - - - - -

        /// <summary>
        /// Adds the Types from the specified Assemblies to this AssemblyScan.
        /// </summary>
        /// <param name="assemblies">The Assemblies to get the Types from.</param>
        /// <returns>Itself.</returns>
        public AssemblyScan AddAssemblies(IEnumerable<Assembly> assemblies)
            => this.AddAssemblyScan(new AssemblyScan { Types = assemblies.SelectMany(a => a.GetTypes()).ToArray() });

        /// <summary>
        /// Adds the Types from the specified Assemblies to this AssemblyScan.
        /// </summary>
        /// <param name="assembly">An Assembly to get Types from.</param>
        /// <param name="additionalAssemblies">Additional Assemblies to get Types from.</param>
        /// <returns>Itself.</returns>
        public AssemblyScan AddAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => this.AddAssemblies(new[] { assembly }.Union(additionalAssemblies));

        /// <summary>
        /// Adds the Types from the specified Assembly to this AssemblyScan.
        /// </summary>
        /// <param name="assembly">The Assembly to get Types from.</param>
        /// <returns>Itself.</returns>
        public AssemblyScan AddAssembly(Assembly assembly)
            => this.AddAssemblies(assembly);

        /// <summary>
        /// Adds the Types from the specified AssemblyScan to this AssemblyScan.
        /// </summary>
        /// <param name="assemblyScan">The AssemblyScan to get Types from.</param>
        /// <returns>Itself.</returns>
        public AssemblyScan AddAssemblyScan(IAssemblyScan assemblyScan)
        {
            this.Types = this.Types.Union(assemblyScan.Types).ToArray();

            return this;
        }

        /// <summary>
        /// Gets an AssemblyScan with no Types.
        /// </summary>
        /// <returns>An empty AssemblyScan.</returns>
        public static AssemblyScan Empty()
            => new AssemblyScan();

        /// <summary>
        /// Gets an AssemblyScan with Types from the specified Assemblies.
        /// </summary>
        /// <param name="assemblies">The Assemblies to get the Types from.</param>
        /// <returns>A populated AssemblyScan.</returns>
        public static AssemblyScan FromAssemblies(IEnumerable<Assembly> assemblies)
            => new AssemblyScan().AddAssemblies(assemblies);

        /// <summary>
        /// Gets an AssemblyScan with Types from the specified Assemblies.
        /// </summary>
        /// <param name="assembly">An Assembly to get Types from.</param>
        /// <param name="additionalAssemblies">Additional Assemblies to get Types from.</param>
        /// <returns>A populated AssemblyScan.</returns>
        public static AssemblyScan FromAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => new AssemblyScan().AddAssemblies(assembly, additionalAssemblies);

        /// <summary>
        /// Gets an AssemblyScan with Types from the specified Assembly.
        /// </summary>
        /// <param name="assembly">The Assembly to get Types from.</param>
        /// <returns>A populated AssemblyScan.</returns>
        public static AssemblyScan FromAssembly(Assembly assembly)
            => new AssemblyScan().AddAssembly(assembly);

        #endregion Methods

    }

}
