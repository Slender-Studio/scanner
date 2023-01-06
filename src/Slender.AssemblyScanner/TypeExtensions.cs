using System;
using System.Collections.Generic;
using System.Linq;

namespace Slender.AssemblyScanner
{

    internal static class TypeExtensions
    {

        #region - - - - - - Methods - - - - - -

        /// <summary>
        /// Gets all classes inherited by the specified type in least-derived order.
        /// </summary>
        /// <param name="type">The type to get all base types for.</param>
        /// <returns>An enumerable of base types.</returns>
        public static IEnumerable<Type> GetBaseTypes(this Type type)
            => type.BaseType == null
                ? Enumerable.Empty<Type>()
                : type.BaseType.GetBaseTypes().Union(new[] { type.BaseType });

        /// <summary>
        /// Gets all interfaces implemented by this type that are not implemented through inheritence.
        /// </summary>
        /// <param name="type">The type to get all direct interfaces for.</param>
        /// <returns>An enumerable of types that are implemented by the specified type.</returns>
        public static IEnumerable<Type> GetDirectInterfaces(this Type type)
            => type.GetInterfaces()
                .Except(type.BaseType?.GetInterfaces() ?? Enumerable.Empty<Type>())
                .Except(type.GetInterfaces().SelectMany(i => i.GetInterfaces()));

        #endregion Methods

    }

}
