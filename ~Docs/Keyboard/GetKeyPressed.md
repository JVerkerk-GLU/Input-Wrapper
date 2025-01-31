# bool GetKeyPressed(KeyId key)
*namespace:* [GLU.Input.Keyboard](../keyboard.md)

---
***Syntax***
```csharp
public static bool GetKeyPressed(KeyId key)
public static bool GetKeyPressed(Key key)
```

## Description
Returns whether the given key associated with the given `key` of type [KeyId](./KeyId.md) was pressed during the current frame.

```csharp
public void Update()
{
    if (Keyboard.GetKeyPressed(KeyId.Space))
    {
        Debug.log("The [Space] key was pressed during this frame");
    }
}
```