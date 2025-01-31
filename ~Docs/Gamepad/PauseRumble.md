# void PauseRumble()
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static void PauseRumble()
```

## Description
Pauses and stores the current rumble intensity so it can be resumed again via the [ResumeRumble](./ResumeRumble.md) function.

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