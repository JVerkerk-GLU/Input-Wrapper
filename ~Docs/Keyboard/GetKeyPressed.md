# bool GetKeyPressed(KeyId key)
*namespace:* [GLU.Input.Keyboard](../keyboard.md)

---
***Syntax***
```csharp
public static bool GetKeyPressed(Key key)
```

## Description
Returns whether the given key associated with the parameter `key` of type [Key](./Key.md) was pressed during the current frame.

```csharp
public void Update()
{
    if (Keyboard.GetKeyPressed(KeyId.Space))
    {
        Debug.log("The [Space] key was pressed during this frame");
    }
}
```