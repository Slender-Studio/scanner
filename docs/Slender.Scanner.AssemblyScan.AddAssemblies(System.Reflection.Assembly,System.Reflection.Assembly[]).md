### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')

## AssemblyScan.AddAssemblies(Assembly, Assembly[]) Method

Adds the types from the specified assemblies to this [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan').

```csharp
public Slender.Scanner.AssemblyScan AddAssemblies(System.Reflection.Assembly assembly, params System.Reflection.Assembly[] additionalAssemblies);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

An [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly') to get types from.

<a name='Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).additionalAssemblies'></a>

`additionalAssemblies` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Additional assemblies to get types from.

#### Returns
[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')  
Itself.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[assembly](Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).md#Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).assembly 'Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly, System.Reflection.Assembly[]).assembly') is null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[additionalAssemblies](Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).md#Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).additionalAssemblies 'Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly, System.Reflection.Assembly[]).additionalAssemblies') is null.