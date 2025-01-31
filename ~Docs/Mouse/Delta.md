# Vector2 Delta
*namespace:* [GLU.Input.Mouse](../mouse.md)

---
***Syntax***
```csharp
public static Vector2 Delta
```

## Description
Returns a `Vector2` based on the mouse's movement since the previous frame.

> If the mouse is locked in place via the [LockPosition](./LockPosition.md) function, the delta is calculated before it is reset to the center of the view

```csharp
[SerializeField] private Transform _Camera;

public void Update()
{
    // Get the current delta in pixels of the mouse
    Vector2 mouseDelta = Mouse.Delta;
    
    // Rotate the object on the Y axis based on the horizontal delta
    transform.Rotate(new Vector3(0f, mouseDelta.x, 0f));
}
```