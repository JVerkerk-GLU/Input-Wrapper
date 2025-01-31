# float Position
*namespace:* [GLU.Input.Mouse](../mouse.md)

---
***Syntax***
```csharp
public static float Scroll
```

## Description
Returns a `float` based on the scroll delta of vertical scrolling where the value is clamped between 1 and -1, 1 being up and -1 being down.

```csharp
public void Update()
{
    // Get the current scrolling
    float scrollDelta = Mouse.Scroll;
    
    // Move an object up and down on the Y axis based on the scroll delta
    transform.position += Vector3.Up * scrollDelta * Time.DeltaTime * 10f;
}
```