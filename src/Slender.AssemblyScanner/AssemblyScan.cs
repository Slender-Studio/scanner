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

        public AssemblyScan AddAssemblies(IEnumerable<Assembly> assemblies)
            => this.AddAssemblyScan(new AssemblyScan { Types = assemblies.SelectMany(a => a.GetTypes()).ToArray() });

        public AssemblyScan AddAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => this.AddAssemblies(new[] { assembly }.Union(additionalAssemblies));

        public AssemblyScan AddAssembly(Assembly assembly)
            => this.AddAssemblies(assembly);

        public AssemblyScan AddAssemblyScan(IAssemblyScan assemblyScan)
        {
            this.Types = this.Types.Union(assemblyScan.Types).ToArray();

            return this;
        }

        public static AssemblyScan Empty()
            => new AssemblyScan();

        public static AssemblyScan FromAssemblies(IEnumerable<Assembly> assemblies)
            => new AssemblyScan().AddAssemblies(assemblies);

        public static AssemblyScan FromAssemblies(Assembly assembly, params Assembly[] additionalAssemblies)
            => new AssemblyScan().AddAssemblies(assembly, additionalAssemblies);

        public static AssemblyScan FromAssembly(Assembly assembly)
            => new AssemblyScan().AddAssembly(assembly);

        #endregion Methods

    }

}
