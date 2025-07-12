### [Slender.Scanner](Slender.Scanner.md 'Slender.Scanner').[TypeExtensions](Slender.Scanner.TypeExtensions.md 'Slender.Scanner.TypeExtensions')

## TypeExtensions.GetBaseType(this Type) Method

Gets the type from which the specified [type](Slender.Scanner.TypeExtensions.GetBaseType(thisSystem.Type).md#Slender.Scanner.TypeExtensions.GetBaseType(thisSystem.Type).type 'Slender.Scanner.TypeExtensions.GetBaseType(this System.Type).type') directly inherits.

```csharp
public static System.Type GetBaseType(this System.Type type);
```
#### Parameters

<a name='Slender.Scanner.TypeExtensions.GetBaseType(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') to get the base type for.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') from which the specified [type](Slender.Scanner.TypeExtensions.GetBaseType(thisSystem.Type).md#Slender.Scanner.TypeExtensions.GetBaseType(thisSystem.Type).type 'Slender.Scanner.TypeExtensions.GetBaseType(this System.Type).type') directly inherits,  
or null if the specified [type](Slender.Scanner.TypeExtensions.GetBaseType(thisSystem.Type).md#Slender.Scanner.TypeExtensions.GetBaseType(thisSystem.Type).type 'Slender.Scanner.TypeExtensions.GetBaseType(this System.Type).type') represents the [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') class or an interface.