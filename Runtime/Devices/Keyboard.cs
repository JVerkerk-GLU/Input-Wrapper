using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GLU.Input
{
    public static class Keyboard
    {
        private static UnityEngine.InputSystem.Keyboard Device => UnityEngine.InputSystem.Keyboard.current ?? throw new NullReferenceException("[<color=#ff0000>There doesn't seem to be a keyboard present</color>]");
        
        private static bool Try(Func<bool> callback)
        {
            try
            {
                return callback();
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException($"[<color=#ff0000>Invalid 'Key' value</color>]", e);
            }
        }

        #region --- Key ---

        /// <summary>
        /// Returns whether the given key is currently being pressed
        /// </summary>
        public static bool GetKey(Key key) => Try(() => Device[key].isPressed);
        
        /// <summary>
        /// Returns whether the given key was pressed in the current frame
        /// </summary>
        public static bool GetKeyPressed(Key key) => Try(() => Device[key].wasPressedThisFrame);
        
        /// <summary>
        /// Returns whether the given key was released in the current frame
        /// </summary>
        public static bool GetKeyReleased(Key key) => Try(() => Device[key].wasReleasedThisFrame);

        #endregion

        #region --- Any Key ---

        /// <summary>
        /// Returns whether any key is currently being pressed
        /// </summary>
        public static bool AnyKey() => Device.anyKey.isPressed;

        /// <summary>
        /// Returns whether any key was pressed in the current frame
        /// </summary>
        public static bool AnyKeyPressed() => Device.anyKey.wasPressedThisFrame;
        
        /// <summary>
        /// Returns whether any key was released in the current frame
        /// </summary>
        public static bool AnyKeyReleased() => Device.anyKey.wasReleasedThisFrame;

        #endregion

        #region --- Bindings ---

        /// <summary>
        /// Returns a Vector2 based on the commonly used WASD and arrow key navigation
        /// </summary>
        public static Vector2 GetAxis() => new Vector2(
            (Device.rightArrowKey.isPressed || Device.dKey.isPressed ? 1 : 0) - // Right
            (Device.leftArrowKey.isPressed || Device.aKey.isPressed ? 1 : 0), // Left

            (Device.upArrowKey.isPressed || Device.wKey.isPressed ? 1 : 0) - // Up
            (Device.downArrowKey.isPressed || Device.sKey.isPressed ? 1 : 0)); // Down

        #endregion
    }
}