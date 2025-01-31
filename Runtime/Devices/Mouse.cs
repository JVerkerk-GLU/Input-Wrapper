using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

namespace GLU.Input
{
    public static class Mouse
    {
        private static UnityEngine.InputSystem.Mouse Device => UnityEngine.InputSystem.Mouse.current ?? throw new NullReferenceException("[<color=#ff0000>There doesn't seem to be a mouse present</color>]");

        private static ButtonControl ParseButton(UnityEngine.InputSystem.LowLevel.MouseButton button)
        {
            return button switch
            {
                UnityEngine.InputSystem.LowLevel.MouseButton.Left => Device.leftButton,
                UnityEngine.InputSystem.LowLevel.MouseButton.Right => Device.rightButton,
                UnityEngine.InputSystem.LowLevel.MouseButton.Middle => Device.middleButton,
                UnityEngine.InputSystem.LowLevel.MouseButton.Forward => Device.forwardButton,
                UnityEngine.InputSystem.LowLevel.MouseButton.Back => Device.backButton,
                _ => throw new ArgumentOutOfRangeException(nameof(button), button,
                    "[<color=#ff0000>Invalid 'MouseButton' value</color>]")
            };
        }

        #region --- Button ---

        /// <summary>
        /// Returns whether the given mouse button is currently being pressed
        /// </summary>
        public static bool GetButton(UnityEngine.InputSystem.LowLevel.MouseButton button)
        {
            ButtonControl control = ParseButton(button);
            return control.isPressed;
        }
        /// <inheritdoc cref="GetButton(UnityEngine.InputSystem.LowLevel.MouseButton)"/>
        public static bool GetButton(MouseButton button) => GetButton((UnityEngine.InputSystem.LowLevel.MouseButton)button);
        /// <inheritdoc cref="GetButton(UnityEngine.InputSystem.LowLevel.MouseButton)"/>
        public static bool GetButton(int button) => GetButton((UnityEngine.InputSystem.LowLevel.MouseButton)button);
        
        /// <summary>
        /// Returns whether the given mouse button was pressed during the current frame
        /// </summary>
        public static bool GetButtonPressed(UnityEngine.InputSystem.LowLevel.MouseButton button)
        {
            ButtonControl control = ParseButton(button);
            return control.wasPressedThisFrame;
        }
        /// <inheritdoc cref="GetButtonPressed(UnityEngine.InputSystem.LowLevel.MouseButton)"/>
        public static bool GetButtonPressed(MouseButton button) => GetButtonPressed((UnityEngine.InputSystem.LowLevel.MouseButton)button);
        /// <inheritdoc cref="GetButtonPressed(UnityEngine.InputSystem.LowLevel.MouseButton)"/>
        public static bool GetButtonPressed(int button) => GetButtonPressed((UnityEngine.InputSystem.LowLevel.MouseButton)button);
        
        /// <summary>
        /// Returns whether the given mouse button was released during the current frame
        /// </summary>
        public static bool GetButtonReleased(UnityEngine.InputSystem.LowLevel.MouseButton button)
        {
            ButtonControl control = ParseButton(button);
            return control.wasReleasedThisFrame;
        }
        /// <inheritdoc cref="GetButtonReleased(UnityEngine.InputSystem.LowLevel.MouseButton)"/>
        public static bool GetButtonReleased(MouseButton button) => GetButtonReleased((UnityEngine.InputSystem.LowLevel.MouseButton)button);
        /// <inheritdoc cref="GetButtonReleased(UnityEngine.InputSystem.LowLevel.MouseButton)"/>
        public static bool GetButtonReleased(int button) => GetButtonReleased((UnityEngine.InputSystem.LowLevel.MouseButton)button);

        #endregion

        #region --- Scroll ---

        /// <summary>
        /// Returns the scroll delta of vertical scrolling where the value is clamped between 1 and -1, 1 being up and -1 being down
        /// </summary>
        public static float Scroll => Device.scroll.ReadValue().normalized.y;
        
        #endregion

        #region --- Position ---

        /// <summary>
        /// Returns the current position of the mouse in pixels based on the left-bottom corner of the screen
        /// </summary>
        public static Vector2 Position => Device.position.ReadValue();
        
        /// <summary>
        /// Returns the difference in position from the last frame to the current frame
        /// </summary>
        /// <remarks> If the mouse is locked in place via the <see cref="LockPosition"/> function, the delta is calculated before it is reset to the center of the view </remarks>
        public static Vector2 Delta => Device.delta.ReadValue();
        
        /// <summary>
        /// Unlocks the mouse, allowing it to move around the game view
        /// </summary>
        /// <remarks>This is the default behaviour</remarks>
        public static void UnlockPosition() => Cursor.lockState = CursorLockMode.None;
        
        /// <summary>
        /// Locks the mouse to the center of the game view (use escape to break free from this limitation)
        /// </summary>
        public static void LockPosition() => Cursor.lockState = CursorLockMode.Locked;
        
        /// <summary>
        /// Confines the mouse to the game view (use escape to break free from this limitation)
        /// </summary>
        public static void ConfinePosition() => Cursor.lockState = CursorLockMode.Confined;

        #endregion
    }
}
