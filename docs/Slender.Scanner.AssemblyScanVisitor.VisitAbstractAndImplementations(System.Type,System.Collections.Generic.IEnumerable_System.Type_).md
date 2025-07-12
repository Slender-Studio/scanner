### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScanVisitor](Slender.Scanner.AssemblyScanVisitor.md 'Slender.Scanner.AssemblyScanVisitor')

## AssemblyScanVisitor.VisitAbstractAndImplementations(Type, IEnumerable<Type>) Method

Visits the specified [abstractType](Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).md#Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).abstractType 'Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type, System.Collections.Generic.IEnumerable<System.Type>).abstractType') and its [implementationTypes](Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).md#Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).implementationTypes 'Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type, System.Collections.Generic.IEnumerable<System.Type>).implementationTypes').

```csharp
protected virtual void VisitAbstractAndImplementations(System.Type abstractType, System.Collections.Generic.IEnumerable<System.Type> implementationTypes);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).abstractType'></a>

`abstractType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The abstract [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') being visited.

<a name='Slender.Scanner.AssemblyScanVisitor.VisitAbstractAndImplementations(System.Type,System.Collections.Generic.IEnumerable_System.Type_).implementationTypes'></a>

`implementationTypes` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The instantiable class types that inherit the abstract [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').