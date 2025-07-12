### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScanVisitor](Slender.Scanner.AssemblyScanVisitor.md 'Slender.Scanner.AssemblyScanVisitor')

## AssemblyScanVisitor.VisitInterfaceAndImplementations(Type, IEnumerable<Type>) Method

Visits the specified [interfaceType](Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).md#Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).interfaceType 'Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type, System.Collections.Generic.IEnumerable<System.Type>).interfaceType') and its [implementationTypes](Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).md#Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).implementationTypes 'Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type, System.Collections.Generic.IEnumerable<System.Type>).implementationTypes').

```csharp
protected virtual void VisitInterfaceAndImplementations(System.Type interfaceType, System.Collections.Generic.IEnumerable<System.Type> implementationTypes);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).interfaceType'></a>

`interfaceType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The interface [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') being visited.

<a name='Slender.Scanner.AssemblyScanVisitor.VisitInterfaceAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).implementationTypes'></a>

`implementationTypes` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The instantiable class types that implement the interface [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').