Slender.Scanner is a simple .NET library for scanning assemblies and visiting their types.

[![NuGet](https://img.shields.io/nuget/v/Slender.Scanner)](https://www.nuget.org/packages/Slender.Scanner) [![NuGet](https://img.shields.io/nuget/dt/Slender.Scanner)](https://www.nuget.org/packages/Slender.Scanner)
### What are the advantages of using Slender.Scanner?
 - Slender.Scanner uses the visitor pattern, so it does most of the work for you. Just override methods to define your logic.
 - The entry point of the visitor is an interface, allowing you to write unit tests for your visitor. Just mock up a scanned assembly and verify your logic.
### How Does It Work?
#### Step 1 - Define types in an assembly.
```c#
public interface IInterface { }

public abstract class BaseClass { }

public class Implementation : BaseClass, IInterface { }
```
#### Step 2 - Define a visitor that inherts from AssemblyScanVisitor.
```c#
public class Visitor : Slender.Scanner.AssemblyScanVisitor
{

}
```
#### Step 3 - Override the Visitor's Visit methods to implement specific behaviours.
###### Example 1: Registering services in an IServiceCollection.
```c#
public class Visitor(IServiceCollection services) : Slender.Scanner.AssemblyScanVisitor
{

    protected override void VisitAbstractAndImplementations(Type abstractType, IEnumerable<Type> implementationTypes)
    {
        foreach (var _ImplementationType in implementationTypes)
            services.AddScoped(abstractType, _ImplementationType);
    }

    protected override void VisitInterfaceAndImplementations(Type interfaceType, IEnumerable<Type> implementationTypes)
    {
        foreach (var _ImplementationType in implementationTypes)
            services.AddScoped(interfaceType, _ImplementationType);
    }

}
```
###### Example 2: Verifying a service implementation exists.
```c#
public class Visitor(Type serviceType) : Slender.Scanner.AssemblyScanVisitor
{

    public bool DoesServiceImplementationExist { get; private set; }

    protected override void VisitInterfaceAndImplementations(Type interfaceType, IEnumerable<Type> implementationTypes)
    {
        if (interfaceType == serviceType)
            this.DoesServiceImplementationExist = true;
    }

}
```
###### Example 3: Finding types with a specific attribute.
```c#
public class Visitor(List<Type> typesWithAttribute) : Slender.Scanner.AssemblyScanVisitor
{

    protected override void VisitType(Type type)
    {
        if (type.CustomAttributes.Any(a => a.AttributeType == typeof(Attribute)))
            typesWithAttribute.Add(type);
    }

}
```
#### Step 4 - Visiting an assembly.
```c#
var _Visitor = new Visitor();
var _AssemblyScan = AssemblyScan.FromAssembly(typeof(Visitor).Assembly);

_Visitor.VisitAssemblyScan(_AssemblyScan);
```
### Docs
Interested in learning more? Check out the [docs](docs/Slender.Scanner.md 'Slender.Scanner').
### Leave a Star :star:
Like the project? Please leave a star!