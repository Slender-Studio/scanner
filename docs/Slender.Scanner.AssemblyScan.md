### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner')

## AssemblyScan Class

Represents a scanned [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly').

```csharp
public class AssemblyScan :
Slender.Scanner.IAssemblyScan
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AssemblyScan

Implements [IAssemblyScan](Slender.Scanner.IAssemblyScan.md 'Slender.Scanner.IAssemblyScan')

| Properties | |
| :--- | :--- |
| [Types](Slender.Scanner.AssemblyScan.Types.md 'Slender.Scanner.AssemblyScan.Types') | The types defined in the scanned [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly'). |

| Methods | |
| :--- | :--- |
| [AddAssemblies(IEnumerable&lt;Assembly&gt;)](Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md 'Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>)') | Adds the types from the specified [assemblies](Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md#Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies 'Slender.Scanner.AssemblyScan.AddAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>).assemblies') to this [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan'). |
| [AddAssemblies(Assembly, Assembly[])](Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).md 'Slender.Scanner.AssemblyScan.AddAssemblies(System.Reflection.Assembly, System.Reflection.Assembly[])') | Adds the types from the specified assemblies to this [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan'). |
| [AddAssembly(Assembly)](Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).md 'Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly)') | Adds the types from the specified [assembly](Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).md#Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).assembly 'Slender.Scanner.AssemblyScan.AddAssembly(System.Reflection.Assembly).assembly') to this [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan'). |
| [AddAssemblyScan(IAssemblyScan)](Slender.Scanner.AssemblyScan.AddAssemblyScan(Slender.Scanner.IAssemblyScan).md 'Slender.Scanner.AssemblyScan.AddAssemblyScan(Slender.Scanner.IAssemblyScan)') | Adds the types from the specified [assemblyScan](Slender.Scanner.AssemblyScan.AddAssemblyScan(Slender.Scanner.IAssemblyScan).md#Slender.Scanner.AssemblyScan.AddAssemblyScan(Slender.Scanner.IAssemblyScan).assemblyScan 'Slender.Scanner.AssemblyScan.AddAssemblyScan(Slender.Scanner.IAssemblyScan).assemblyScan') to this [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan'). |
| [Empty()](Slender.Scanner.AssemblyScan.Empty().md 'Slender.Scanner.AssemblyScan.Empty()') | Gets an [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan') with no types. |
| [FromAssemblies(IEnumerable&lt;Assembly&gt;)](Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md 'Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>)') | Gets an [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan') with types from the specified [assemblies](Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).md#Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable_System.Reflection.Assembly_).assemblies 'Slender.Scanner.AssemblyScan.FromAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>).assemblies'). |
| [FromAssemblies(Assembly, Assembly[])](Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly,System.Reflection.Assembly[]).md 'Slender.Scanner.AssemblyScan.FromAssemblies(System.Reflection.Assembly, System.Reflection.Assembly[])') | Gets an [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan') with types from the specified assemblies. |
| [FromAssembly(Assembly)](Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).md 'Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly)') | Gets an [AssemblyScan](Slender.Scanner.AssemblyScan.md 'Slender.Scanner.AssemblyScan') with types from the specified [assembly](Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).md#Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).assembly 'Slender.Scanner.AssemblyScan.FromAssembly(System.Reflection.Assembly).assembly'). |
