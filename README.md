# ksp-logirgb
Allows Kerbal Space Program to modify the lighting on your Logitech RGB Keyboard.
Lights up your keyboard to make playing Kerbal Space Program a lot easier.

**This is a fork of @cguckes' awesome ksp-chroma plugin - if you have a Razer keyboard, check it out: https://github.com/cguckes/ksp-chroma**

The mod is still very beta, so let me know if you experience any difficulties when using it.

## Features

- Function keys 1 to 0 are only lit, if the underlying action group actually does anything. The keys are displayed in two different colors, depending on whether the action group is toggled or not.
- The keys for SAS, RCS, Gears, Lights and the Brakes are lit up in different colors, indicating if the respective system was activated or not.
- The amount of resources in the current stage is displayed on your keypad and the keys to the left of it (PrtScr, ScrLk, ..., PageDown)
- The color of W, A, S, D, E and Q varies slightly depending on whether you're in precision or normal steering mode
- The keys for timewarp control are lit either red for physics timewarp or green for normal timewarp

## Full list of game effects

- Stylized Kerbal Space Program logo on every scene that does not contain any noteworthy keyboard interaction (pressing Escape to go to the menu not being noteworthy enough to light up the key)
- In the vessel editor, different kinds of keysets are lit up according to the current editor mode.
- Control keys and toggleable function keys are lit up in different colors, showing whether the function is switched on or off during flight.
- Reduced keyset lit for EVA mode
- Resource gauges displayed on the keypad and the keys above the UpDownLeftRight keys.

## Installation

1. Unzip the release archive and place the KSPLogiRGB folder in your KSP GameData directory.
2. From either the lib32 or lib64 folder (depending on which KSP build you are using) copy the LogitechLedEnginesWrapper.dll file inside the GameRoot, where the KSP.exe and KSP_x64.exe are as well.
3. Start KSP and witness the awesomeness of highlighted function keys while kerbaling through space
 
## Todo

- Make the whole keyboard red, if the vessel is not steerable any more.
- Add CatastrophicFailure event and SplashedDown event animation.
