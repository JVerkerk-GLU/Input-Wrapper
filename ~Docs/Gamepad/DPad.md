# Vector2 DPad
*namespace:* [GLU.Input.Gamepad](../gamepad.md)

---
***Syntax***
```csharp
public static Vector2 DPad
```

## Description
Returns a `Vector2` based on the right D-Pad's accentuation on a -1 to 1 scale.

```csharp
public void Update()
{
    // Translate the position of the gameObject based on the Gamepad's right Joystick
    transform.position += Gamepad.DPad * Time.DeltaTime;
}
```