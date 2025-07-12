using System;
using System.Collections.Generic;
using System.Linq;

namespace Slender.Scanner
{

    /// <summary>
    /// Contains <see cref="Type"/> extension methods.
    /// </summary>
    internal static class TypeExtensions
    {

        #region - - - - - - Methods - - - - - -

        /// <summary>
        /// Gets the type from which the specified <paramref name="type"/> directly inherits.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to get the base type for.</param>
        /// <returns>
        /// The <see cref="Type"/> from which the specified <paramref name="type"/> directly inherits,
        /// or null if the specified <paramref name="type"/> represents the <see cref="object"/> class or an interface.
        /// </returns>
        public static Type GetBaseType(this Type type)
            => type.BaseType == null
                ? null
                : GetTypeDefinition(type.BaseType);

        /// <summary>
        /// Gets all the interfaces implemented or inherited by the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to get the interfaces for.</param>
        /// <returns>        
        /// An enumerable of <see cref="Type"/> objects representing all the interfaces implemented or
        /// inherited by the specified <paramref name="type"/>. -or- An empty enumerable of <see cref="Type"/>,
        /// if no interfaces are implemented or inherited by the specified <paramref name="type"/>.
        /// </returns>
        public static IEnumerable<Type> GetImplementedInterfaces(this Type type)
            => type.GetInterfaces().Select(t => GetTypeDefinition(t));

        private static Type GetTypeDefinition(Type type)
            => type.IsGenericType && type.GetGenericArguments().All(t => t.IsGenericParameter)
                ? type.GetGenericTypeDefinition()
                : type;

        #endregion Methods

    }

}
