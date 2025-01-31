# Vector2 RightJoystick
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static Vector2 RightJoystick
```

## Description
Returns a `Vector2` based on the right joystick's accentuation on a -1 to 1 scale.

```csharp
public void Update()
{
    // Translate the position of the gameObject based on the Gamepad's right Joystick
    transform.position += Gamepad.RightJoystick * Time.DeltaTime;
}
```