/* 
 * Copied 1:1 from the UnityEngine.InputSystem.Internal.GamepadButton Enum for the sake of easy access for students (no need to implement multiple namespaces).
 */

namespace GLU.Input
{
    public enum GamepadButton
    {
        // Dpad buttons. Important to be first in the bitfield as we'll
        // point the DpadControl to it.
        // IMPORTANT: Order has to match what is expected by DpadControl.

        /// <summary>
        /// The up button on a gamepad's dpad.
        /// </summary>
        DpadUp = 0,

        /// <summary>
        /// The down button on a gamepad's dpad.
        /// </summary>
        DpadDown = 1,

        /// <summary>
        /// The left button on a gamepad's dpad.
        /// </summary>
        DpadLeft = 2,

        /// <summary>
        /// The right button on a gamepad's dpad.
        /// </summary>
        DpadRight = 3,

        // Face buttons. We go with a north/south/east/west naming as that
        // clearly disambiguates where we expect the respective button to be.

        /// <summary>
        /// The upper action button on a gamepad.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="Y"/> and <see cref="Triangle"/> which are the Xbox and PlayStation controller names for this button.
        /// </remarks>
        North = 4,

        /// <summary>
        /// The right action button on a gamepad.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="B"/> and <see cref="Circle"/> which are the Xbox and PlayStation controller names for this button.
        /// </remarks>
        East = 5,

        /// <summary>
        /// The lower action button on a gamepad.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="A"/> and <see cref="Cross"/> which are the Xbox and PlayStation controller names for this button.
        /// </remarks>
        South = 6,

        /// <summary>
        /// The left action button on a gamepad.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="X"/> and <see cref="Square"/> which are the Xbox and PlayStation controller names for this button.
        /// </remarks>
        West = 7,


        /// <summary>
        /// The button pressed by pressing down the left stick on a gamepad.
        /// </summary>
        LeftStick = 8,

        /// <summary>
        /// The button pressed by pressing down the right stick on a gamepad.
        /// </summary>
        RightStick = 9,

        /// <summary>
        /// The left shoulder button on a gamepad.
        /// </summary>
        LeftShoulder = 10,

        /// <summary>
        /// The right shoulder button on a gamepad.
        /// </summary>
        RightShoulder = 11,

        /// <summary>
        /// The start button.
        /// </summary>
        Start = 12,

        /// <summary>
        /// The select button.
        /// </summary>
        Select = 13,

        // For values that are not part of the buttons bitmask in GamepadState, assign large values that are outside
        // the 32bit bit range.

        /// <summary>
        /// The left trigger button on a gamepad.
        /// </summary>
        LeftTrigger = 32,

        /// <summary>
        /// The right trigger button on a gamepad.
        /// </summary>
        RightTrigger = 33,

        /// <summary>
        /// The X button on an Xbox controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="West"/>, which is the generic name of this button.
        /// </remarks>
        X = West,
        /// <summary>
        /// The Y button on an Xbox controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="North"/>, which is the generic name of this button.
        /// </remarks>
        Y = North,
        /// <summary>
        /// The A button on an Xbox controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="South"/>, which is the generic name of this button.
        /// </remarks>
        A = South,
        /// <summary>
        /// The B button on an Xbox controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="East"/>, which is the generic name of this button.
        /// </remarks>
        B = East,

        /// <summary>
        /// The cross button on a PlayStation controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="South"/>, which is the generic name of this button.
        /// </remarks>
        Cross = South,
        /// <summary>
        /// The square button on a PlayStation controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="West"/>, which is the generic name of this button.
        /// </remarks>
        Square = West,
        /// <summary>
        /// The triangle button on a PlayStation controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="North"/>, which is the generic name of this button.
        /// </remarks>
        Triangle = North,
        /// <summary>
        /// The circle button on a PlayStation controller.
        /// </summary>
        /// <remarks>
        /// Identical to <see cref="East"/>, which is the generic name of this button.
        /// </remarks>
        Circle = East,
    }
}
