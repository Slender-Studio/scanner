using System;
using System.Collections.Generic;
using System.Linq;

namespace Slender.AssemblyScanner
{

    public class AssemblyScanVisitor
    {

        #region - - - - - - Methods - - - - - -

        private static IEnumerable<Type> GetAbstractBases(Type type)
            => type == null
                ? Enumerable.Empty<Type>()
                : type.IsAbstract
                    ? GetAbstractBases(type.BaseType).Union(new[] { type })
                    : GetAbstractBases(type.BaseType);

        private static List<Type> GetOrAdd(Dictionary<Type, List<Type>> dictionary, Type type)
        {
            if (!dictionary.TryGetValue(type, out var _List))
            {
                _List = new List<Type>();
                dictionary.Add(type, _List);
            }
            return _List;
        }

        protected virtual IEnumerable<Type> GetTypesToVisit(IAssemblyScan scan)
            => scan.Types;

        protected virtual void VisitAbstract(Type abstractType) { }

        protected virtual void VisitAbstractAndImplementations(Type abstractType, IEnumerable<Type> implementationTypes) { }

        public virtual void VisitAssemblyScan(IAssemblyScan scan)
        {
            if (scan is null) throw new ArgumentNullException(nameof(scan));

            var _AbstractImplementations = new Dictionary<Type, List<Type>>();
            var _InterfaceImplementations = new Dictionary<Type, List<Type>>();

            foreach (var _Type in this.GetTypesToVisit(scan))
            {
                this.VisitType(_Type);

                if (_Type.IsClass && !_Type.IsAbstract && _Type.BaseType != typeof(MulticastDelegate))
                {
                    foreach (var _AbstractBase in GetAbstractBases(_Type))
                        GetOrAdd(_AbstractImplementations, _AbstractBase).Add(_Type);

                    foreach (var _Interface in _Type.GetDirectInterfaces())
                        GetOrAdd(_InterfaceImplementations, _Interface).Add(_Type);
                }
            }

            foreach (var _AbstractAndImplementations in _AbstractImplementations)
                this.VisitAbstractAndImplementations(_AbstractAndImplementations.Key, _AbstractAndImplementations.Value);

            foreach (var _IntercaceAndImplementations in _InterfaceImplementations)
                this.VisitInterfaceAndImplementations(_IntercaceAndImplementations.Key, _IntercaceAndImplementations.Value);
        }

        protected virtual void VisitDelegate(Type delegateType) { }

        protected virtual void VisitEnumeration(Type enumerationType) { }

        protected virtual void VisitImplementation(Type implementationType) { }

        protected virtual void VisitInterface(Type interfaceType) { }

        protected virtual void VisitInterfaceAndImplementations(Type interfaceType, IEnumerable<Type> implementationTypes) { }

        protected virtual void VisitType(Type type)
        {
            if (type.IsEnum)
                this.VisitEnumeration(type);

            else if (type.IsInterface) // Needs to be before IsAbstract, as an Interface is Abstract.
                this.VisitInterface(type);

            else if (type.IsAbstract)
            {
                // A Static class is an Abstract Sealed Class.
                if (!type.IsSealed) this.VisitAbstract(type);
            }
            else if (type.IsValueType)
                this.VisitValueType(type);

            else if (type.BaseType == typeof(MulticastDelegate)) // Needs to be before IsClass, as a delegate is a Class.
                this.VisitDelegate(type);

            else if (type.IsClass)
                this.VisitImplementation(type);
        }

        protected virtual void VisitValueType(Type valueType) { }

        #endregion Methods

    }

}
