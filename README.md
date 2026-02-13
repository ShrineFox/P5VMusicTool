# P5VMusicTool
Tool for generating BGM for P5R Vinesauce Mod

## About
Due to limitations of AWB Emulator and Ryo Framework, BGM tracks need to be duplicated in order to be used in multiple situations.  
To make the mod more compact to distribute, I've designed a tool to generate BGM replacements from a user profile .json.
This has several other advantages:  
- I don't need to remember where to replace each track if I need to make adjustments (i.e. loop points, volume)
- Users can easily personalize their own track lists without understanding the technical workings of the mod  
The first time the mod starts up, it will use the tool in commandline mode to generate track lists using the Default profile.
## Interface
Main interface has two lists on the left pane. First is Collections. These can be Red Vox albums, fan covers, and other music used in the mod. Each Collection has a folder.  
Next pane is Songs. These are .ADX files inside the collection folder.  
When a Collection is selected, you can select Songs in that collection.  
When a Song is selected, in the rest of the interface you can assign properties, such as destinations for the songs. You can choose from a preset list of destinations (Battle, Boss, Mementos, Costume Battle/Victory...) or for advanced users (i.e. the mod developers, define your own destination).  
Each destination is represented by a checkbox.  
Each song needs an ID. This is what will be used to assign it to either an existing track, or add it to the list of new tracks for use with Ryo/Costume Frameworks. For a list of Cue IDs, see the Amicitia Wiki's P5R BGM page.
