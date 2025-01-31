# bool GetButton(MouseButtonId button)
*namespace:* [GLU.Mouse](../mouse.md)

---
***Syntax***
```csharp
public static bool GetButton(MouseButtonId button)
public static bool GetButton(MouseButton button)
```

## Description
Returns whether the given button associated with the given `button` of type [MouseButtonId](./MouseButtonId.md) is currently being pressed.

```csharp
public void Update()
{
    if (Mouse.GetButton(MouseButtonId.Left))
    {
        Debug.log("The [Left Mouse Button] is currently being pressed");
    }
}
```