# Vector2 LeftJoystick
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static Vector2 LeftJoystick
```

## Description
Returns a `Vector2` based on the left joystick's accentuation on a -1 to 1 scale.

```csharp
public void Update()
{
    // Translate the position of the gameObject based on the Gamepad's Left Joystick
    transform.position += Gamepad.LeftJoystick * Time.DeltaTime;
}
```