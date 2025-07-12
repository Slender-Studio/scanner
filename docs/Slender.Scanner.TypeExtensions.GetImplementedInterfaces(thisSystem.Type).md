### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[TypeExtensions](Slender.Scanner.TypeExtensions.md 'Slender.Scanner.TypeExtensions')

## TypeExtensions.GetImplementedInterfaces(this Type) Method

Gets all the interfaces implemented or inherited by the specified [type](Slender.Scanner.TypeExtensions.GetImplementedInterfaces(thisSystem.Type).md#Slender.Scanner.TypeExtensions.GetImplementedInterfaces(thisSystem.Type).type 'Slender.Scanner.TypeExtensions.GetImplementedInterfaces(this System.Type).type').

```csharp
public static System.Collections.Generic.IEnumerable<System.Type> GetImplementedInterfaces(this System.Type type);
```
#### Parameters

<a name='Slender.Scanner.TypeExtensions.GetImplementedInterfaces(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') to get the interfaces for.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumerable of [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') objects representing all the interfaces implemented or  
inherited by the specified [type](Slender.Scanner.TypeExtensions.GetImplementedInterfaces(thisSystem.Type).md#Slender.Scanner.TypeExtensions.GetImplementedInterfaces(thisSystem.Type).type 'Slender.Scanner.TypeExtensions.GetImplementedInterfaces(this System.Type).type'). -or- An empty enumerable of [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type'),  
if no interfaces are implemented or inherited by the specified [type](Slender.Scanner.TypeExtensions.GetImplementedInterfaces(thisSystem.Type).md#Slender.Scanner.TypeExtensions.GetImplementedInterfaces(thisSystem.Type).type 'Slender.Scanner.TypeExtensions.GetImplementedInterfaces(this System.Type).type').