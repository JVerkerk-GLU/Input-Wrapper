# bool GetKeyReleased(KeyId key)
*namespace:* [GLU.Input.Keyboard](../keyboard.md)

---
***Syntax***
```csharp
public static bool GetKeyReleased(Key key)
```

## Description
Returns whether the given key associated with the parameter `key` of type [Key](./Key.md) was released during the current frame.

```csharp
public void Update()
{
    if (Keyboard.GetKeyReleased(Key.Space))
    {
        Debug.log("The [Space] key was released during this frame");
    }
}
```