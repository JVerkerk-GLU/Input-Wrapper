# bool GetButtonReleased(MouseButtonId button)
*namespace:* [GLU.Input.Mouse](../mouse.md)

---
***Syntax***
```csharp
public static bool GetButtonReleased(MouseButton button)
```

## Description
Returns whether the given button associated with the parameter `button` of type [MouseButton](./MouseButton.md) was released during the current frame.

```csharp
public void Update()
{
    if (Mouse.GetButtonReleased(MouseButtonId.Left))
    {
        Debug.log("The [Left Mouse Button] was released during the current frame");
    }
}
```