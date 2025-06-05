namespace Slender.Scanner.Sample
{

    public class LoggingVisitor : AssemblyScanVisitor
    {

        #region - - - - - - Methods - - - - - -

        protected override void VisitAbstract(Type abstractType)
            => Console.WriteLine($"Visiting Abstract: {abstractType.Name}");

        protected override void VisitAbstractAndImplementations(Type abstractType, IEnumerable<Type> implementationTypes)
            => Console.WriteLine($"Visiting Abstract: {abstractType.Name}, with Implementations: {string.Join(", ", implementationTypes.Select(t => t.Name))}");

        protected override void VisitDelegate(Type delegateType)
            => Console.WriteLine($"Visiting Delegate: {delegateType.Name}");

        protected override void VisitEnumeration(Type enumerationType)
            => Console.WriteLine($"Visiting Enumeration: {enumerationType.Name}");

        protected override void VisitImplementation(Type implementationType)
            => Console.WriteLine($"Visiting Implementation: {implementationType.Name}");

        protected override void VisitInterface(Type interfaceType)
            => Console.WriteLine($"Visiting Interface: {interfaceType.Name}");

        protected override void VisitInterfaceAndImplementations(Type interfaceType, IEnumerable<Type> implementationTypes)
            => Console.WriteLine($"Visiting Interface: {interfaceType.Name}, with Implementations: {string.Join(", ", implementationTypes.Select(t => t.Name))}");

        protected override void VisitValueType(Type valueType)
            => Console.WriteLine($"Visiting Abstract: {valueType.Name}");

        #endregion Methods

    }

}
