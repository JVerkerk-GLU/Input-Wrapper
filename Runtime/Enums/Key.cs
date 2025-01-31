/* 
 * Copied 1:1 from the UnityEngine.InputSystem.Internal.Key Enum for the sake of easy access for students (no need to implement multiple namespaces).
 */

namespace GLU.Input
{
    public enum Key
    {
        /// <summary>
        /// Invalid key. Does not represent a key on the keyboard and is only used to have a
        /// default for the Key enumeration not represent any specific key.
        /// </summary>
        None,

        // ---- Printable keys ----

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.spaceKey"/>.
        /// </summary>
        Space,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.enterKey"/>.
        /// </summary>
        Enter,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.tabKey"/>.
        /// </summary>
        Tab,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.backquoteKey"/>.
        /// </summary>
        Backquote,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.quoteKey"/>.
        /// </summary>
        Quote,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.semicolonKey"/>.
        /// </summary>
        Semicolon,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.commaKey"/>.
        /// </summary>
        Comma,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.periodKey"/>.
        /// </summary>
        Period,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.slashKey"/>.
        /// </summary>
        Slash,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.backslashKey"/>.
        /// </summary>
        Backslash,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.leftBracketKey"/>.
        /// </summary>
        LeftBracket,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.rightBracketKey"/>.
        /// </summary>
        RightBracket,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.minusKey"/>.
        /// </summary>
        Minus,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.equalsKey"/>.
        /// </summary>
        Equals,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.aKey"/>.
        /// </summary>
        A,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.bKey"/>.
        /// </summary>
        B,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.cKey"/>.
        /// </summary>
        C,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.dKey"/>.
        /// </summary>
        D,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.eKey"/>.
        /// </summary>
        E,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.fKey"/>.
        /// </summary>
        F,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.gKey"/>.
        /// </summary>
        G,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.hKey"/>.
        /// </summary>
        H,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.iKey"/>.
        /// </summary>
        I,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.jKey"/>.
        /// </summary>
        J,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.kKey"/>.
        /// </summary>
        K,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.lKey"/>.
        /// </summary>
        L,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.mKey"/>.
        /// </summary>
        M,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.nKey"/>.
        /// </summary>
        N,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.oKey"/>.
        /// </summary>
        O,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.pKey"/>.
        /// </summary>
        P,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.qKey"/>.
        /// </summary>
        Q,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.rKey"/>.
        /// </summary>
        R,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.sKey"/>.
        /// </summary>
        S,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.tKey"/>.
        /// </summary>
        T,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.uKey"/>.
        /// </summary>
        U,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.vKey"/>.
        /// </summary>
        V,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.wKey"/>.
        /// </summary>
        W,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.xKey"/>.
        /// </summary>
        X,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.yKey"/>.
        /// </summary>
        Y,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.zKey"/>.
        /// </summary>
        Z,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit1Key"/>.
        /// </summary>
        Digit1,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit2Key"/>.
        /// </summary>
        Digit2,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit3Key"/>.
        /// </summary>
        Digit3,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit4Key"/>.
        /// </summary>
        Digit4,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit5Key"/>.
        /// </summary>
        Digit5,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit6Key"/>.
        /// </summary>
        Digit6,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit7Key"/>.
        /// </summary>
        Digit7,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit8Key"/>.
        /// </summary>
        Digit8,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit9Key"/>.
        /// </summary>
        Digit9,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.digit0Key"/>.
        /// </summary>
        Digit0,

        // ---- Non-printable keys ----

        // NOTE: The left&right variants for shift, ctrl, and alt must be next to each other.

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.leftShiftKey"/>.
        /// </summary>
        LeftShift,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.rightShiftKey"/>.
        /// </summary>
        RightShift,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.leftAltKey"/>.
        /// </summary>
        LeftAlt,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.rightAltKey"/>.
        /// </summary>
        RightAlt,

        /// <summary>
        /// Same as <see cref="RightAlt"/>.
        /// </summary>
        AltGr = RightAlt,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.leftCtrlKey"/>.
        /// </summary>
        LeftCtrl,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.rightCtrlKey"/>.
        /// </summary>
        RightCtrl,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.leftMetaKey"/>.
        /// </summary>
        LeftMeta,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.rightMetaKey"/>.
        /// </summary>
        RightMeta,

        /// <summary>
        /// Same as <see cref="LeftMeta"/>.
        /// </summary>
        LeftWindows = LeftMeta,

        /// <summary>
        /// Same as <see cref="RightMeta"/>.
        /// </summary>
        RightWindows = RightMeta,

        /// <summary>
        /// Same as <see cref="LeftMeta"/>.
        /// </summary>
        LeftApple = LeftMeta,

        /// <summary>
        /// Same as <see cref="RightMeta"/>.
        /// </summary>
        RightApple = RightMeta,

        /// <summary>
        /// Same as <see cref="LeftMeta"/>.
        /// </summary>
        LeftCommand = LeftMeta,

        /// <summary>
        /// Same as <see cref="RightMeta"/>.
        /// </summary>
        RightCommand = RightMeta,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.contextMenuKey"/>.
        /// </summary>
        ContextMenu,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.escapeKey"/>.
        /// </summary>
        Escape,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.leftArrowKey"/>.
        /// </summary>
        LeftArrow,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.rightArrowKey"/>.
        /// </summary>
        RightArrow,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.upArrowKey"/>.
        /// </summary>
        UpArrow,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.downArrowKey"/>.
        /// </summary>
        DownArrow,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.backspaceKey"/>.
        /// </summary>
        Backspace,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.pageDownKey"/>.
        /// </summary>
        PageDown,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.pageUpKey"/>.
        /// </summary>
        PageUp,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.homeKey"/>.
        /// </summary>
        Home,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.endKey"/>.
        /// </summary>
        End,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.insertKey"/>.
        /// </summary>
        Insert,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.deleteKey"/>.
        /// </summary>
        Delete,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.capsLockKey"/>.
        /// </summary>
        CapsLock,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numLockKey"/>.
        /// </summary>
        NumLock,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.printScreenKey"/>.
        /// </summary>
        PrintScreen,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.scrollLockKey"/>.
        /// </summary>
        ScrollLock,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.pauseKey"/>.
        /// </summary>
        Pause,

        // ---- Numpad ----
        // NOTE: Numpad layout follows the 18-key numpad layout. Some PC keyboards
        //       have a 17-key numpad layout where the plus key is an elongated key
        //       like the numpad enter key. Be aware that in those layouts the positions
        //       of some of the operator keys are also different. However, we stay
        //       layout neutral here, too, and always use the 18-key blueprint.

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpadEnterKey"/>.
        /// </summary>
        NumpadEnter,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpadDivideKey"/>.
        /// </summary>
        NumpadDivide,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpadMultiplyKey"/>.
        /// </summary>
        NumpadMultiply,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpadPlusKey"/>.
        /// </summary>
        NumpadPlus,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpadMinusKey"/>.
        /// </summary>
        NumpadMinus,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpadPeriodKey"/>.
        /// </summary>
        NumpadPeriod,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpadEqualsKey"/>.
        /// </summary>
        NumpadEquals,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad0Key"/>.
        /// </summary>
        Numpad0,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad1Key"/>.
        /// </summary>
        Numpad1,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad2Key"/>.
        /// </summary>
        Numpad2,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad3Key"/>.
        /// </summary>
        Numpad3,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad4Key"/>.
        /// </summary>
        Numpad4,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad5Key"/>.
        /// </summary>
        Numpad5,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad6Key"/>.
        /// </summary>
        Numpad6,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad7Key"/>.
        /// </summary>
        Numpad7,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad8Key"/>.
        /// </summary>
        Numpad8,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.numpad9Key"/>.
        /// </summary>
        Numpad9,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f1Key"/>.
        /// </summary>
        F1,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f2Key"/>.
        /// </summary>
        F2,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f3Key"/>.
        /// </summary>
        F3,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f4Key"/>.
        /// </summary>
        F4,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f5Key"/>.
        /// </summary>
        F5,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f6Key"/>.
        /// </summary>
        F6,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f7Key"/>.
        /// </summary>
        F7,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f8Key"/>.
        /// </summary>
        F8,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f9Key"/>.
        /// </summary>
        F9,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f10Key"/>.
        /// </summary>
        F10,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f11Key"/>.
        /// </summary>
        F11,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.f12Key"/>.
        /// </summary>
        F12,

        // Extra keys that a keyboard may have. We make no guarantees about where
        // they end up on the keyboard (if they are present).

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.oem1Key"/>.
        /// </summary>
        OEM1,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.oem2Key"/>.
        /// </summary>
        OEM2,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.oem3Key"/>.
        /// </summary>
        OEM3,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.oem4Key"/>.
        /// </summary>
        OEM4,

        /// <summary>
        /// The <see cref="UnityEngine.InputSystem.Keyboard.oem5Key"/>.
        /// </summary>
        OEM5,

        ////FIXME: This should never have been a Key but rather just an extra button or state on keyboard
        // Not exactly a key, but binary data sent by the Keyboard to say if IME is being used.
        IMESelected
    }
}
