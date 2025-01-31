# Device - Gamepad
*Namespace:* [GLU.Input](../README.md)

---
A wrapper around gamepad input allowing the polling of key presses, joystick interaction, and even rumble.

## Static Methods
<table>
    <tbody>
        <tr>
            <td><a href="./Gamepad/GetButton.md">GetButton</a></td>
            <td>Returns whether the given key is currently being pressed</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/GetButtonPressed.md">GetButtonPressed</a></td>
            <td>Returns whether the given key was pressed in the current frame</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/GetButtonReleased.md">GetButtonReleased</a></td>
            <td>Returns whether the given key was released in the current frame</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/PauseRumble.md">PauseRumble</a></td>
            <td>Pauses the two rumble motors inside the gamepad</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/ResumeRumble.md">ResumeRumble</a></td>
            <td>Resumes the two rumble motors inside the gamepad</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/SetRumble.md">SetRumble</a></td>
            <td>Sets the intensity of the two rumble motors inside the gamepad</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/StopRumble.md">StopRumble</a></td>
            <td>Stops the two rumble motors inside the gamepad</td>
        </tr>
    </tbody>
</table>

## Static Properties
<table>
    <tbody>
        <tr>
            <td><a href="./Gamepad/DPad.md">DPad</a></td>
            <td>Gets the current accentuation of the D-Pad</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/IsConnected.md">IsConnected</a></td>
            <td>Returns whether a gamepad is currently present</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/LeftJoystick.md">LeftJoystick</a></td>
            <td>Gets the current accentuation of the left joystick</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/LeftTrigger.md">LeftTrigger</a></td>
            <td>Gets the current accentuation of the left trigger, 0 being completely released and 1 being completely pressed</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/RightJoystick.md">RightJoystick</a></td>
            <td>Gets the current accentuation of the right joystick</td>
        </tr>
        <tr>
            <td><a href="./Gamepad/RightTrigger.md">RightTrigger</a></td>
            <td>Gets the current accentuation of the right trigger, 0 being completely released and 1 being completely pressed</td>
        </tr>
    </tbody>
</table>

## Enumeration
<table>
    <tbody>
        <tr>
            <td><a href="./Gamepad/GamepadButton.md">GamepadButton</a></td>
            <td>A named list of all gamepad buttons available for input</td>
        </tr>
    </tbody>
</table>