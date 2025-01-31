# Vector2 Position
*namespace:* [GLU.Input.Mouse](../mouse.md)

---
***Syntax***
```csharp
public static Vector2 Position
```

## Description
Returns a `Vector2` based on the mouse's current position in pixels based on the left-bottom corner of the screen.

```csharp
public void Update()
{
    // Get the current position in pixels of the mouse
    Vector2 mousePosition = Mouse.Position;
    
    // Convert a pixel based position to a world based position
    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
    
    // Set the position of the gameObject to the provided mouse location
    transform.position = mousePosition;
}
```