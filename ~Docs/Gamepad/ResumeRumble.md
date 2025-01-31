# void ResumeRumble()
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static void ResumeRumble()
```

## Description
Resumes the rumble at the same intensity as it was when the [PauseRumble](./PauseRumble.md) function was called.

```csharp
public void Update()
{
    // Sets the gamepad's rumble based on the Left and Right trigger
    Gamepad.SetRumble(Gamepad.LeftTrigger, Gamepad.RightTrigger);
}

private void OnApplicationFocus(bool hasFocus)
{
    if (hasFocus)
    {
        // Pauses the rumble when the game loses focus
        Gamepad.ResumeRumble();
    }
    else 
    {
        // Resumes the rumble when the game regains focus
        Gamepad.PauseRumble();
    }
}
```