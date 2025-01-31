# bool GetButtonPressed(GamepadButton button)
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static bool GetButtonPressed(GamepadButton button)
```

## Description
Returns whether the given button associated with the parameter `button` of type [GamepadButton](./GamepadButton.md) was pressed during the current frame.

```csharp
public void Update()
{
    if (Gamepad.GetButtonPressed(GamepadButton.Start))
    {
        Debug.log("The [Start] key was pressed during the current frame");
    }
}
```