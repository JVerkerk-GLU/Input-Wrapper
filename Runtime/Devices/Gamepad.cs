using System;
using UnityEngine;

namespace GLU.Input
{
    public static class Gamepad
    {
        private static UnityEngine.InputSystem.Gamepad Device => UnityEngine.InputSystem.Gamepad.current ??
                                                                 throw new NullReferenceException(
                                                                     "[<color=#ff0000>There doesn't seem to be a gamepad present</color>]");
        private const string EVENT_ERROR = "Invalid 'GamepadButton' value";

        /// <summary>
        /// Returns whether a gamepad is currently present
        /// </summary>
        public static bool IsConnected => UnityEngine.InputSystem.Gamepad.current != null;
        
        #region --- Joysticks ---

        /// <summary>
        /// Gets the current accentuation of the left joystick
        /// </summary>
        public static Vector2 LeftJoystick => Device.leftStick.ReadValue();

        /// <summary>
        /// Gets the current accentuation of the right joystick
        /// </summary>
        public static Vector2 RightJoystick => Device.rightStick.ReadValue();

        /// <summary>
        /// Gets the current accentuation of the D-Pad
        /// </summary>
        public static Vector2 DPad => Device.dpad.ReadValue();

        #endregion

        #region --- Triggers ---

        /// <summary>
        /// Gets the current accentuation of the left trigger, 0 being completely released and 1 being completely pressed
        /// </summary>
        public static float LeftTrigger => Device.leftTrigger.ReadValue();
        
        /// <summary>
        /// Gets the current accentuation of the right trigger, 0 being completely released and 1 being completely pressed
        /// </summary>
        public static float RightTrigger => Device.leftTrigger.ReadValue();

        #endregion

        #region --- Buttons ---

        /// <summary>
        /// Returns whether the given key is currently being pressed
        /// </summary>
        public static bool GetButton(UnityEngine.InputSystem.LowLevel.GamepadButton button) => Events.Try(() => Device[button].isPressed, EVENT_ERROR);
        /// <inheritdoc cref="GetButton(UnityEngine.InputSystem.LowLevel.GamepadButton)"/>
        public static bool GetButton(GamepadButton button) => GetButton((UnityEngine.InputSystem.LowLevel.GamepadButton)button);
        
        /// <summary>
        /// Returns whether the given key was pressed in the current frame
        /// </summary>
        public static bool GetButtonPressed(UnityEngine.InputSystem.LowLevel.GamepadButton button) => Events.Try(() => Device[button].wasPressedThisFrame, EVENT_ERROR);
        /// <inheritdoc cref="GetButtonPressed(UnityEngine.InputSystem.LowLevel.GamepadButton)"/>
        public static bool GetButtonPressed(GamepadButton button) => GetButtonPressed((UnityEngine.InputSystem.LowLevel.GamepadButton)button);
        
        /// <summary>
        /// Returns whether the given key was released in the current frame
        /// </summary>
        public static bool GetButtonReleased(UnityEngine.InputSystem.LowLevel.GamepadButton button) => Events.Try(() => Device[button].wasReleasedThisFrame, EVENT_ERROR);
        /// <inheritdoc cref="GetButtonReleased(UnityEngine.InputSystem.LowLevel.GamepadButton)"/>
        public static bool GetButtonReleased(GamepadButton button) => GetButtonReleased((UnityEngine.InputSystem.LowLevel.GamepadButton)button);

        #endregion
        
        #region --- Rumble ---

        /// <summary>
        /// Sets the intensity of the two rumble motors inside the gamepad
        /// </summary>
        public static void SetRumble(float lowFrequency, float highFrequency) => Device.SetMotorSpeeds(lowFrequency, highFrequency);

        /// <summary>
        /// Pauses the two rumble motors inside the gamepad
        /// </summary>
        public static void PauseRumble() => Device.PauseHaptics();
        
        /// <summary>
        /// Resumes the two rumble motors inside the gamepad
        /// </summary>
        public static void ResumeRumble() => Device.ResumeHaptics();
        
        /// <summary>
        /// Stops the two rumble motors inside the gamepad
        /// </summary>
        public static void StopRumble() => Device.SetMotorSpeeds(0, 0);

        #endregion
    }
}
