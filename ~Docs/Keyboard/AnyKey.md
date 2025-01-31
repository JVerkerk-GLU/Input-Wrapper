# bool AnyKey()
*namespace:* [GLU.Keyboard](../keyboard.md)

***Syntax***
```csharp
public static bool AnyKey()
```

## Description
Returns whether any key on the keyboard is currently being pressed.

```csharp
public void Update()
{
    if (Keyboard.AnyKey())
    {
        Debug.log("A key on the keyboard is currently being pressed");
    }
}
```