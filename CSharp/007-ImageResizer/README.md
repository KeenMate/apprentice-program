# ImageResizer 3000

Image resizer looks for all \*.jpg/jpeg files in a folder that user enters and creates their thumbnails or resize them to desired size


## Limitations & guidance

- Try to use LINQ as much as possible
- Use [Command line arguments](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line) to tell the program what to do
- Use [SixLabors.ImageSharp](https://www.nuget.org/packages/SixLabors.ImageSharp/) package for image manipulation
	- Use their guide to find out how it works

## Description


### Command line specification 

- Command line arguments works like this
	- All parameters starts with - or --
		- For example command resize can be entered as -r or -resize, to resize images the application would be called ImageResizer3000.exe -r or ImageResizer3000.exe --resize
	- First argument is directory path
		- If user does not enter directory path, ask user to enter it
		- For example, ImageResizer3000.exe c:\\temp\\images --resize
	- If parameter require an additional value to be entered it uses = as delimiter
		- For example, ImageResizer3000.exe c:\\temp\\images --resize --width=600
- Available command line arguments
	- Directory path as first argument
	- -r or --resize to start resizing process
	- -w=x or --width=x that specifies desired width, where x is an integer number between 100-1200
	- -t or --thumbs to create thumbs for each image
	- -c or --clean to clean up all thumbs and resized images
 
### Commands and processing

- Check if the users entered folder exists, if not display a warning and end the program
- *--resize*
	- Resize command requires width parameter, check if it was entered if not display a warning and end the program
	- Find all \*.jpeg or \*.jpg files in the entered folder
		- If there are none, display a warning and end the program
	- For each file
		- Check if resized version of file does not exists already
			- Remove it if it does
		- Resize the image with _ImageSharp_ to entered width
		- Save the resized image to [original_file_name_without_extension].[width].jpeg
		- Print out message "Image {original_file_name_without_extension} resized in {elapsedTime}ms"
- *--thumbs*
	- Check if .\\thumbs folder exists, create it if it doesn't
	- Find all \*.jpeg or \*.jpg files in the entered folder
		- If there are none, display a warning and end the program
	- For each file
		- Check if resized version of file does not exists already
			- Remove it if it does
		- Resize the image with _ImageSharp_ to width 75px
		- Save the resized image to [original_file_name_without_extension].jpeg in .\\thumbs folder
		- Print out message "Image thumb for {original_file_name_without_extension} created in {elapsedTime}ms"
- *--clean*
	- Remove .\\thumbs folder
	- Remove all files that are in format [name].[width].jpeg
		- _width_ must be an string that can be converted to an integer number
