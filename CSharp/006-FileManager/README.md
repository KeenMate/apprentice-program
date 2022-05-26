# Filemanager 3000

## Limitations

- Do NOT use traditional for/foreach cycles, use only LINQ
- Use List<>, use classes, be good
- There is no hidden catch in this description, no need to look for it, it's all just plain programming

## Description

### Phase 1

- Ask user for a directory
	- Default value c:\Windows\System32
		- Try to use SpecialFolder enum to retrive the fullpath of System32 folder and do not use string value for directory path
	- Create or use a method that you can reuse in other projects and this method will ask user in format [question] (Default: [defaultValue]): [no new line, user press enter and default value is used OR puts new value]
	- Do so until user enters a directory that exists
		- If directory does not exists print an error message "Directory with path {directoryPath} does not exist"
- Ask user for a list of extensions
	- Defaults to empty string
	- Extensions are separated by ; and in format .[extension]
		- If user enters .png; .jpeg trim the leading space infront of .jpeg
			- Find out what string trim does and what are your options
			- Remember there is something like LINQ Select, use it
- If user enters no extensions
	- Get all files
	- Get all distinct extensions from all files
	- Print out how many files is there for each extension and their total file size 
		- Sort the list from the biggest groups
		- Print these groups in a table
		- Print total sizes in x.xxMB format = with two decimal places
		- Try to align count and total size columns to the right side
		- DO NOT print it right away, first prepare your data and the print it as the last command
- If users enters some extensions
	- Get only files with these extensions
	- Everything else is above
	

### Phase 2
- After the application is started user is presented with a menu and below that menu is a text "Choose your option: "
	- Menu options are
		- 1. File extension statistics
		- 2. Create backup file
		- 3. List backup files
	- When user enters an invalid menu option number, a message "Invalid menu option selected" is printed in red color for 750ms, screen is cleared and menu is printed again

#### Create backup file
- Ask user for a directory
	-  Default value c:\temp
- Check if the entered directory exists, if not create it
- Take all files in root of the entered directory, put them in a zip file called backup.zip, create a folder with name [current time and date in format yyyy-mm-dd_hh-mm-ss] and save the zip file into this folder

#### List backup files
- Ask user for a directory
	-  Default value c:\temp
- Get all directories in the root of entered directory, print all folders that contains backup file in a numbered list and ask user "Which file you'd like to open: "
	- If user enters existing number, open selected file with Process.Start("explorer", [full file path])
		- After file is opened ask user for new number
	- If user enters invalid number, display warning and ask again for correct number
	- If user enters character 'b' he is returned to main menu

## Hints

- Remember: you can create classes for your temporary results to store data before you print it
- Remember: In the beginning was the Word, and the Word was with List, and the Word was List
