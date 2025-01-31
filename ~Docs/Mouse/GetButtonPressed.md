# bool GetButtonPressed(MouseButtonId button)
*namespace:* [GLU.Input.Mouse](../mouse.md)

---
***Syntax***
```csharp
public static bool GetButtonPressed(MouseButtonId button)
public static bool GetButtonPressed(MouseButton button)
```

## Description
Returns whether the given button associated with the given `button` of type [MouseButtonId](./MouseButtonId.md) was pressed during the current frame.

```csharp
public void Update()
{
    if (Mouse.GetButtonPressed(MouseButtonId.Left))
    {
        Debug.log("The [Left Mouse Button] was pressed during the current frame");
    }
}
```