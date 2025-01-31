# void StopRumble()
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static void StopRumble()
```

## Description
Sets both rumble motors inside the gamepad to 0, stopping any rumble currently going on.

```csharp
public void Update()
{
    // Sets the gamepad's rumble based on the Left and Right trigger
    Gamepad.SetRumble(Gamepad.LeftTrigger, Gamepad.RightTrigger);
}

private void OnDestroy()
{
    // Stop any rumble currently active when the gameObject is destroyed
    Gamepad.StopRumble();
}
```