### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')

## AssemblyScan.AddAssemblies(IEnumerable<Assembly>) Method

Adds the types from the specified [assemblies](Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md#Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies 'Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>).assemblies') to this [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan').

```csharp
public Slender.Scanner.AssemblyScan AddAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies'></a>

`assemblies` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The assemblies to get the types from.

#### Returns
[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')  
Itself.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[assemblies](Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md#Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies 'Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>).assemblies') is null.