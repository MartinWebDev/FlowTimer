Downloads of this version available on Releases page

# Arm switch

Added in "arm switch" functionality, found in the settings screen. Using this means you can set the "Start" hotkey to the same button in game as your action you want to time with. In FF7, I bind my "Start" to the cancel button so the timer starts exactly when the menu closes with a single button. I activate the arm function while waiting for the menu to open. 

The feedback for this function is currently very simple, so feedback always welcome. Long story short, if you set a key to the Arm function, it WILL be required to start the timer. The timer text will turn red when armed.\
If you do not bind a hotkey to this function, it will not be required, and the start function will work as it always did before.

![Arm switch hotkey](docs/arm-switch-hotkey.jpg?raw=true "Arm Switch Hotkey")

![Timer armed](docs/timer-armed.jpg?raw=true "Armed!")

# Metronome functionality

For those more musically inclined, or for those who just want a more distinct way to follow the beeps if you use a higher count, I added a metronome style timer. Functionally it works exactly the same as the regular fixed offset timer, except instead of every beep being the same, the first beep of every bar is different to the other three.\
Instead of setting the interval between beeps and number of beeps, you instead choose your time signature, bpm, and total number of full bars.\
The final beep will be the first beat of the next bar after. EG, if you set a 4/4 timing and 2 total bars, you will get "1, 2, 3, 4, 1, 2, 3, 4, 1" or "beep-boop-boop-boop beep-boop-boop-boop beep".

- See below for example settings. Note, that I have not yet added in the labels (among other things) so use the labels in this image for reference when testing this out.
- You will also need to select the radio button as I have not yet done tihs automatically on switching to the tab. (Circled in red).
- Currently do not have a dropdown selector for time signature, so under "beats per bar" you have to type it out. 
  - ALSO: This currently *needs* to be "4" as temporarily I have harded coded the beep order. I plan to change this later, so you can then do custom time sigs if you wanted.

![Metronome tab settings](docs/metronome-tab.jpg?raw=true "Metronome tab")

## General TODO
- Save settings and automatically recall them at next open.
- Lint entire application and bring it up to C# design standards and best practices
  - Address various spacing issues
  - Ensure zero index checking of things such as tabs (better still, use an enum)
