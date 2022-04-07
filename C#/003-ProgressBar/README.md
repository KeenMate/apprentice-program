# Progess bar
Create a progress bar in console application that draws a progress bar with UTF8 characters.

All tasks run after each other, when one finishes there are two new empty lines printed and next task starts.

Tasks:
 - (First type) Print progress bar 40 characters long
   - Steps 40
   - Each step waits 200ms
   - Each step is represented with \u2593 character
   - Progress bar ends with text x/40 steps, where x is the number of steps already finished
   - For example (X represents \u2593 character)
     - 1st step: X 1/40 steps
     - 2nd step: XX 2/40 steps
     - ..
     - 15th step: XXXXXXXXXXXXXXX 15/40 steps

 - (Second type) Print progress with fixed 50 characters
   - Steps 50
   - At the begining all 50 characters are printed out with \u2591
    - Each step rewrites respective character
   - Each step is divided into 3 stages
    - Each step division waits 100ms
    - First division is represented with \u2951
    - Second division is represented with \u2952
    - Third division is represented with \u2953
   - Progress bar ends with text x/50 steps, where x is the number of steps already finished

- Print first type progress bar with random values
  - Steps are randomly determined with Random.Next, max value 25
  - Each step waits random amount of time, max. waiting time is 500ms
  - Everything else is the same as in the description of the First type progress bar


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
