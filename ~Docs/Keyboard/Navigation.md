# Vector2 Navigation
*namespace:* [GLU.Keyboard](../keyboard.md)

***Syntax***
```csharp
public static Vector2 Navigation
```

## Description
Returns a `Vector2` based on the commonly used WASD and arrow key navigation on a -1 to 1 scale.

The `A` & `D` or `Left Arrow` and `Right Arrow` keys being used for the X-axis of the Vector2, `A` or the `Left Arrow` being -1 and `D` or the `Right Arrow` being 1.

The `W` & `S` or `Up Arrow` and `Down Arrow` keys being used for the Y-axis of the Vector2, `W` or the `Up Arrow` being 1 and `S` or the `Down Arrow` being -1.

```csharp
public void Update()
{
    // Move the current object around on the X and Y axis based on the Navigation input
    transform.position += Keyboard.Navigation * Time.DeltaTime;
}
```