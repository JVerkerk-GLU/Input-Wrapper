using System;
using UnityEngine;

namespace GLU.Input.Examples
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class KeyboardExample : MonoBehaviour
    {
        private SpriteRenderer _renderer;
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
            // Get the sprite renderer
            _renderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            // Change the position based on the current WASD or Arrow key input
            transform.position += (Vector3)Keyboard.Navigation * Time.deltaTime * 2f;

            // Check if the space key was pressed this frame
            if (Keyboard.GetKeyPressed(Key.Space))
            {
                // Loop through the colors
                _renderer.color = COLORS[++_currentColor % COLORS.Length];
            }
            
            // Check if the R key was pressed this frame
            if (Keyboard.GetKeyPressed(Key.R))
            {
                // Reset position to (0, 0)
                transform.position = Vector2.zero;
            }
        }
    }
}