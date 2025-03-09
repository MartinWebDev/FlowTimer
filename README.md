Downloads of thisd version available on Releases page

# TODO
- Update clicks to a 4/4 timer. First click different to other 3. EG: "Click clack clack clack, click clack clack clack, click"
  - Timer controls (on tab) to be "Total bars", "bpm", and "Time Signature"
	- Supported time signatures: 4/4, 3/4
  - Settings form changes: Remove or disabled the alert sound option for now, maybe later support custom click and clack sounds. For now, enforce ping1 and ping2.
- End timer specifically on first beat of nth bar, where n is `total bars + 1`
  - Will need to calculate total number of beeps as `(timing * bars) + 1`, eg: `(4 time sig * 2 bars) + 1 = 9 total beats`
  - Will need to calculate interval between beeps as `60000 / bpm` eg: `60000ms / 200bpm = interval of 300ms`
  - Toggle each beep event between click and clack with: `current beep index % timesig = 0`
    - eg: `0 % 4 == 0 => click`
    - eg: `2 % 4 == 2 => clack`
    - eg: `4 % 4 == 0 => click`
    - eg: `0 % 3 == 0 => click`
    - eg: `2 % 3 == 1 => clack`
    - eg: `3 % 3 == 0 => click`
- Global hotkey to "arm" timer. So can bind timer start key to in game control for perfect starts every time.
- Save settings and automatically recall them at next open.
- Lint entire application and bring it up to C# design standards and best practices
  - Address various spacing issues
  - Ensure zero index checking of things such as tabs (better still, use an enum)
