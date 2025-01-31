# float RightTrigger
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static float RightTrigger
```

## Description
Gets the current accentuation of the right trigger, 0 being completely released and 1 being completely pressed

```csharp
public void Update()
{
    // Sets the gamepad's rumble based on the Left and Right trigger
    Gamepad.SetRumble(Gamepad.LeftTrigger, Gamepad.RightTrigger);
}
```