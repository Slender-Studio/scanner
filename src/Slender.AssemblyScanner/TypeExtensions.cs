using System;
using System.Collections.Generic;
using System.Linq;

namespace Slender.AssemblyScanner
{

    internal static class TypeExtensions
    {

        #region - - - - - - Methods - - - - - -

        internal static IEnumerable<Type> GetDirectInterfaces(this Type type)
            => type.GetInterfaces().Except(type.GetInterfaces().SelectMany(i => i.GetInterfaces()));

        #endregion Methods

    }

}
