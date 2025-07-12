### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')

## AssemblyScan.FromAssemblies(IEnumerable<Assembly>) Method

Gets an [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan') with types from the specified [assemblies](Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md#Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies 'Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>).assemblies').

```csharp
public static Slender.Scanner.AssemblyScan FromAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies'></a>

`assemblies` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The assemblies to get the types from.

#### Returns
[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')  
A populated [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[assemblies](Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md#Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies 'Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>).assemblies') is null.