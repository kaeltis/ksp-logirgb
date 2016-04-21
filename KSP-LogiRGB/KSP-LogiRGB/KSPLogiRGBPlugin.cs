using System.Collections.Generic;
using KSP_LogiRGB.ColorSchemes;
using KSP_LogiRGB.SceneManagers;
using UnityEngine;

namespace KSP_LogiRGB
{
    /// <summary>
    ///     The main class, managing the keyboard appearance for every kind of scene KSP
    ///     uses.
    /// </summary>
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    public class KSPLogiRGBPlugin : MonoBehaviour
    {
        private readonly List<DataDrain> dataDrains = new List<DataDrain>();
        private readonly SceneManager flightSceneManager = new FlightSceneManager();
        private readonly SceneManager vabSceneManager = new VABSceneManager();

        /// <summary>
        ///     Called by unity during the launch of this addon.
        /// </summary>
        private void Awake()
        {
            dataDrains.Add(new LogitechDrain());
        }

        /// <summary>
        ///     Called by unity on every physics frame.
        /// </summary>
        private void FixedUpdate()
        {
            ColorScheme scheme;

            switch (HighLogic.LoadedScene)
            {
                case GameScenes.FLIGHT:
                    scheme = flightSceneManager.getScheme();
                    break;
                case GameScenes.EDITOR:
                    scheme = vabSceneManager.getScheme();
                    break;
                default:
                    scheme = new LogoScheme();
                    break;
            }

            dataDrains.ForEach(drain => drain.send(scheme));
        }
    }
}