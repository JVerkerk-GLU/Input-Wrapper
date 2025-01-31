# bool GetButtonReleased(GamepadButton button)
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static bool GetButtonReleased(GamepadButton button)
```

## Description
Returns whether the given button associated with the parameter `button` of type [GamepadButton](./GamepadButton.md) was released during the current frame.

```csharp
public void Update()
{
    if (Gamepad.GetButtonReleased(GamepadButton.Start))
    {
        Debug.log("The [Start] key was released during the current frame");
    }
}
```