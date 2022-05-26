# Filemanager 3000

## Limitations

- Do NOT use traditional for/foreach cycles, use only LINQ
- Use List<>, use classes, be good

## Description

- Ask user for a directory
	- Default value c:\Windows\System32
		- Try to use SpecialFolder enum to retrive the fullpath of System32 folder and do not use string value for directory path
	- Create or use a method that you can reuse in other projects and this method will ask user in format [question] (Default: [defaultValue]): [no new line, user press enter and default value is used OR puts new value]
	- Do so until user enters a directory that exists
		- If directory does not exists print an error message "Directory with path {directoryPath} does not exist"
- Ask user for a list of extensions
	- Defaults to empty string
	- Extensions are separated by ;
		- If user enters .png; .jpeg trim the leading space infront of .jpeg
			- Find out what string trim does and what are your options
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
	

## Hints

- Remember: you can create classes for your temporary results to store data before you print it
- Remember: In the beginning was the Word, and the Word was with List, and the Word was List