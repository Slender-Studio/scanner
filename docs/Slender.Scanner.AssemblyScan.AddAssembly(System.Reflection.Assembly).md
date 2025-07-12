### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')

## AssemblyScan.AddAssembly(Assembly) Method

Adds the types from the specified [assembly](Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).md#Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).assembly 'Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).assembly') to this [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan').

```csharp
public Slender.Scanner.AssemblyScan AddAssembly(System.Reflection.Assembly assembly);
```
#### Parameters

<a name='Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

The [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly') to get types from.

#### Returns
[AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan')  
Itself.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[assembly](Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).md#Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).assembly 'Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).assembly') is null.