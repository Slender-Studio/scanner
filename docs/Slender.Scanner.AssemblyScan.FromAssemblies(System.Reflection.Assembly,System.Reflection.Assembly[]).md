### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')

## AssemblyScan.FromAssemblies(Assembly, Assembly[]) Method

Gets an [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan') with types from the specified assemblies.

```csharp
public static Slender.Scanner.AssemblyScan FromAssemblies(System.Reflection.Assembly assembly, params System.Reflection.Assembly[] additionalAssemblies);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

An [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly') to get types from.

<a name='Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).additionalAssemblies'></a>

`additionalAssemblies` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Additional assemblies to get types from.

#### Returns
[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')  
A populated [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[assembly](Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).md#Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).assembly 'Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly, System.Reflection.Assembly[]).assembly') is null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[additionalAssemblies](Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).md#Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).additionalAssemblies 'Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly, System.Reflection.Assembly[]).additionalAssemblies') is null.