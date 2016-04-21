using System;
using System.Collections.Generic;
using UnityEngine;

namespace KSP_LogiRGB.ColorSchemes
{
    /// <summary>
    ///     Represents a base color scheme, saving all the colors per key.
    /// </summary>
    public class ColorScheme : Dictionary<KeyCode, Color>
    {
        /// <summary>
        ///     Creates a new ColorScheme rendering all keys black;
        /// </summary>
        public ColorScheme() : this(Color.black)
        {
        }

        /// <summary>
        ///     Creates a new ColorScheme rendering all keys in the defined color.
        /// </summary>
        /// <param name="color">The color to use</param>
        public ColorScheme(Color color)
        {
            foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
            {
                if (!ContainsKey(key))
                    Add(key, color);
                else
                    this[key] = color;
            }

            // Remove the non-existing key.
            Remove(KeyCode.None);
        }


        public void SetKeyToColor(KeyCode key, Color color)
        {
            if (ContainsKey(key))
                this[key] = color;
        }

        /// <summary>
        ///     Sets a number of keys to the defined color
        /// </summary>
        /// <param name="keys">An array of keys to light up</param>
        /// <param name="color">The color to use</param>
        public void SetKeysToColor(KeyCode[] keys, Color color)
        {
            foreach (var key in keys)
            {
                SetKeyToColor(key, color);
            }
        }
    }
}