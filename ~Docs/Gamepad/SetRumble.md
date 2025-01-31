# void SetRumble(float lowFrequency, float highFrequency)
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static void SetRumble(float lowFrequency, float highFrequency)
```

## Description
Sets the intensity of the two rumble motors inside the gamepad

```csharp
public void Update()
{
    // Sets the gamepad's rumble based on the Left and Right trigger
    Gamepad.SetRumble(Gamepad.LeftTrigger, Gamepad.RightTrigger);
}
```