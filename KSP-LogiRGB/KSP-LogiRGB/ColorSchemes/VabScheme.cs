using KSP_LogiRGB.ColorSchemes;
using UnityEngine;

namespace KSP_LogiRGB.SceneManagers
{
    /// <summary>
    ///     Contains the base color scheme for all VAB and SPH scenes.
    /// </summary>
    internal class VabScheme : ColorScheme
    {
        /// <summary>
        ///     Overlays the defined key colors over the base color scheme.
        /// </summary>
        public VabScheme()
        {
            SetKeysToColor(new[]
            {
                KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.Q, KeyCode.E
            }, new Color(1f, 1f, 0f));
            SetKeysToColor(new[]
            {
                KeyCode.LeftShift, KeyCode.Space, KeyCode.F
            }, Color.magenta);
        }
    }
}