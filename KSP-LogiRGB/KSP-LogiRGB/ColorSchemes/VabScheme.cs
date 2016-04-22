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
                GameSettings.Editor_pitchUp.primary, GameSettings.Editor_pitchDown.primary,
                GameSettings.Editor_rollLeft.primary, GameSettings.Editor_rollRight.primary,
                GameSettings.Editor_yawLeft.primary, GameSettings.Editor_yawRight.primary
            }, new Color(1f, 1f, 0f));
            SetKeysToColor(new[]
            {
                GameSettings.Editor_fineTweak.primary,
                GameSettings.Editor_resetRotation.primary,
                GameSettings.Editor_coordSystem.primary
            }, Color.magenta);
        }
    }
}