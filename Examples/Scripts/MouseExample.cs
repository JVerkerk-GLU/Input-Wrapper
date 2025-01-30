using System;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;

namespace GLU.Input.Examples
{
    [RequireComponent(typeof(Text))]
    public class MouseExample : MonoBehaviour
    {
        // Note: Using Legacy UI Text so we don't need to implement TMPro
        private Text _textField;
        private int _currentColor = 0;
        
        // All possible colors to switch between
        private static readonly Color[] COLORS =
        {
            Color.white,
            Color.red,
            Color.green,
            Color.blue,
        };

        private void Awake()
        {
            _textField = GetComponent<Text>();
        }

        private void Update()
        {
            // Update the text to display the current mouse position in pixels based on the left-bottom corner
            _textField.text = $"Mouse Position: {Mouse.Position.ToString("F0")}{Environment.NewLine}Left Mouse Button: Change Colors";
            
            // Check if the left-mouse button was pressed this frame
            if (Mouse.GetButtonPressed(MouseButton.Left))
            {
                // Loop through the colors
                _textField.color = COLORS[++_currentColor % COLORS.Length];
            }
        }
    }
}
