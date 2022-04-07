# Progess bar
Create a progress bar in console application that draws a progress bar with UTF8 characters.

All tasks run after each other, when one finishes there are two new empty lines printed and next task starts.

Tasks:
 - Print progress bar 40 characters long
   - Steps 40
   - Each step waits 200ms
   - Each step is represented with \u2593 character
   - Progress bar ends with text x/40 steps, where x is the number of steps already finished
   - For example (X represents \u2593 character)
     - 1st step: X 1/40 steps
     - 2nd step: XX 2/40 steps
     - ..
     - 15th step: XXXXXXXXXXXXXXX 15/40 steps

 - Print progress with fixed 50 characters
   - 





## Help

- Don't forget to set your Windows console font to Consolas for consistent experience
  - Use defaults settings to keep the settings between restarts of the program
  - [How to setup default font](https://superuser.com/a/965261)
- [UTF8 Box drawing characters](https://en.wikipedia.org/wiki/Box-drawing_character)
  - Unicode characters can be printed to console with \u escape mechanism, for example like this Console.WriteLine("\u2593"), which prints heavy brick like character
- [Thread.Sleep to pause processing for some time](https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-6.0)
- [Console class specification](https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netcore-3.1)
  -	Use CursorLeft, CursorTop to get current cursor position. 
  - Use SetCursorPosition to set new cursor position
  - Use CursorVisible to disable blinking cursor
- [How to generate random number using Random class](https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=netcore-3.1#system-random-next(system-int32))
