# bool GetButton(GamepadButton button)
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static bool GetButton(GamepadButton button)
```

## Description
Returns whether the given button associated with the parameter `button` of type [GamepadButton](./GamepadButton.md) is currently being pressed.

```csharp
public void Update()
{
    if (Gamepad.GetButton(GamepadButton.Start))
    {
        Debug.log("The [Start] key is currently being pressed");
    }
}
```