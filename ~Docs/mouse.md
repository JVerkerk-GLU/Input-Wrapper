# Device - Mouse
*Namespace:* [GLU.Input](../README.md)

---
A wrapper around mouse input allowing the polling of mouse button presses and mouse position.

## Static Methods
<table>
    <tbody>
        <tr>
            <td><a href="./Mouse/ConfinePosition.md">ConfinePosition</a></td>
            <td>Confines the mouse to the game view (use escape to break free from this limitation)</td>
        </tr>
        <tr>
            <td><a href="./Mouse/GetButton.md">GetButton</a></td>
            <td>Returns whether the given mouse button is currently being pressed</td>
        </tr>
        <tr>
            <td><a href="./Mouse/GetButtonPressed.md">GetButtonPressed</a></td>
            <td>Returns whether the given mouse button was pressed during the current frame</td>
        </tr>
        <tr>
            <td><a href="./Mouse/GetButtonPressed.md">GetButtonReleased</a></td>
            <td>Returns whether the given mouse button was released during the current frame</td>
        </tr>
        <tr>
            <td><a href="./Mouse/LockPosition.md">LockPosition</a></td>
            <td>Locks the mouse to the center of the game view (use escape to break free from this limitation)</td>
        </tr>
        <tr>
            <td><a href="./Mouse/UnlockPosition.md">UnlockPosition</a></td>
            <td>Unlocks the mouse, allowing it to move around the game view</td>
        </tr>
    </tbody>
</table>

## Static Properties
<table>
    <tbody>
        <tr>
            <td><a href="./Mouse/Delta.md">Delta</a></td>
            <td>Returns the difference in position from the last frame to the current frame</td>
        </tr>
        <tr>
            <td><a href="./Mouse/Position.md">Position</a></td>
            <td>Returns the current position of the mouse in pixels based on the left-bottom corner of the screen</td>
        </tr>
        <tr>
            <td><a href="./Mouse/Scroll.md">Scroll</a></td>
            <td>Returns the scroll delta of vertical scrolling where the value is clamped between 1 and -1, 1 being up and -1 being down</td>
        </tr>
    </tbody>
</table>

## Enumeration
<table>
    <tbody>
        <tr>
            <td><a href="./Mouse/MouseButton.md">MouseButtonId</a></td>
            <td>A named list of all mouse buttons available for input</td>
        </tr>
    </tbody>
</table>