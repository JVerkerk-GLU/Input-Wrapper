# bool GetKey(EKey key)
*namespace:* [GLU.Keyboard](../keyboard.md)

***Syntax***
```csharp
public static bool GetKey(KeyId key)
public static bool GetKey(Key key)
```

## Description
Returns whether the given key associated with the given `key` of type [KeyId](./KeyId.md) is currently being pressed.

```csharp
public void Update()
{
    if (Keyboard.GetKey(KeyId.Space))
    {
        Debug.log("The [Space] key is currently being pressed");
    }
}
```