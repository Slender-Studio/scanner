### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')

## AssemblyScan.FromAssembly(Assembly) Method

Gets an [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan') with types from the specified [assembly](Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).md#Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).assembly 'Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).assembly').

```csharp
public static Slender.Scanner.AssemblyScan FromAssembly(System.Reflection.Assembly assembly);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

The [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly') to get types from.

#### Returns
[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')  
A populated [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[assembly](Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).md#Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).assembly 'Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).assembly') is null.