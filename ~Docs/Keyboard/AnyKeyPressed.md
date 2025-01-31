# bool AnyKeyPressed()
*namespace:* [GLU.Input.Keyboard](../keyboard.md)

---
***Syntax***
```csharp
public static bool AnyKey()
```

## Description
Returns whether any key on the keyboard was pressed during the current frame.

```csharp
public void Update()
{
    if (Keyboard.AnyKeyPressed())
    {
        Debug.log("A key on the keyboard was pressed during the current frame");
    }
}
```