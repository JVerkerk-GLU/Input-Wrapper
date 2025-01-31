# bool GetKeyReleased(KeyId key)
*namespace:* [GLU.Input.Keyboard](../keyboard.md)

---
***Syntax***
```csharp
public static bool GetKeyReleased(KeyId key)
public static bool GetKeyReleased(Key key)
```

## Description
Returns whether the given key associated with the given `key` of type [KeyId](./KeyId.md) was released during the current frame.

```csharp
public void Update()
{
    if (Keyboard.GetKeyReleased(Key.Space))
    {
        Debug.log("The [Space] key was released during this frame");
    }
}
```