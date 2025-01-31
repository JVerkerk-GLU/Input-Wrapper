# bool GetKey(KeyId key)
*namespace:* [GLU.Input.Keyboard](../keyboard.md)

---
***Syntax***
```csharp
public static bool GetKey(Key key)
```

## Description
Returns whether the given key associated with the parameter `key` of type [Key](./Key.md) is currently being pressed.

```csharp
public void Update()
{
    if (Keyboard.GetKey(KeyId.Space))
    {
        Debug.log("The [Space] key is currently being pressed");
    }
}
```