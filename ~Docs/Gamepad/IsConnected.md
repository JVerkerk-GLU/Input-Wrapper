# bool IsConnected
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static bool IsConnected
```

## Description
Returns whether a gamepad is currently connected.

> Any other call to the Gamepad will throw an error, so it is best if you check beforehand whether a gamepad is connected

```csharp
public void Update()
{
    // Checks if a controller is connected
    if (Gamepad.IsConnected)
    {
        // Translate the position of the gameObject based on the Gamepad's Left Joystick
        transform.position += Gamepad.LeftJoystick * Time.DeltaTime;
    }
    else 
    {
        // Translate the position of the gameObject based on the Keyboard Navigation input
        transform.position += Keyboard.Navigation * Time.DeltaTime;
    }
}
```