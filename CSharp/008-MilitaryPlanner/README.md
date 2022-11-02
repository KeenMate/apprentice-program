# Military Planner 3000

Military planner helps armies with planning their resources when going to battle.

Military planner is divided to three parts
- Definition of basic military resources
- Definition of units
- Battle planner

All calculations are based on how much of basic resources you plan to use per day, how much these resources consume every day and how much long the battle is going to last.

## Limitations & guidance

- Use the knowledge from previous training applications
- Build a Console application
- Business code is separated in a C# library project, so it can be reused in ASP.NET Web variation of this tool
	+ [What a library project is and why to use it?](https://www.youtube.com/watch?v=HOpCbl9Ky_g)
- All data are stored in json file on exit of the application and are automatically loaded on the start of the application
	+ User can clear all or parts of the data in the file from the within the application
		* For example, remove only units and battle plan but keep definition of military resources

## Definition of basic military resources

In this part of the application user is able to create basic resources and define their requirements.

Basic resources are for example soldier, Main battle tank (MBT), Infantry fighting vehicles (IFC), Armored personnel carriers (APC) and soldier.

Since each resource requires different things to work properly, resources are stored in a list and not as property of an object.
For example
- MBT requires 500L of diesel fuel per day, 35 HE rounds, 15 AP rounds, 5kg of grease
- APC requires 150L of diesel fuel per day, 300 7.62mm rounds, 0.75kg of grease
- Soldier requires 5L of water per day, 100 7.62mm rounds, 5 grenades

User can list all resources, add them, edit each resource and update its requirements or delete it. This is implemented either by simple numbered list, where user enters a number of item to edit, or some more sofisticated method, for example by using arrows.

Requirements are entered in three steps, first what is required, then how much and then of what unit.

Each resources is assigned unique number so it can be referenced from units.

## Definition of units

In this part of the application user is able to define military units, for example companies, brigades and so on.

Each unit can be a combination of resources defined in the first part. User selects a resources and then enters how many of it is in the unit. For example, selects MBT and enters 5.

User can list all units, add them, edit each unit and update its resources or delete it.

Each unit is assigned unique number so it can be referenced from battle planner.

## Battle planner

In this part of the application user is able to define battles plans that represent a single battle.

Battles are defined by battle plans, each battle plan contains a list of units that are part of the plan and how long it will last.

After each unit is added to the battle plan and amount of days is entered a summary of all requirements is calculated and displayed on the screen.

## Hints

- Try to create a set of common functions for reading a number, reading a text and so on from console input
- Try to create a set of common functions for displaying data and menus
- Avoid any Console.WriteLines and other Console manipulation inside the business code, it will not do anything once used in ASP.NET Core Web application
	+ All lower level functions will accept all they need either via a global variable of the class or via a function parameter
