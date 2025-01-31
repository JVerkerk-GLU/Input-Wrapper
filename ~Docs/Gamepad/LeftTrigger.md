# float LeftTrigger
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static float LeftTrigger
```

## Description
Gets the current accentuation of the left trigger, 0 being completely released and 1 being completely pressed

```csharp
public void Update()
{
    // Sets the gamepad's rumble based on the Left and Right trigger
    Gamepad.SetRumble(Gamepad.LeftTrigger, Gamepad.RightTrigger);
}
```