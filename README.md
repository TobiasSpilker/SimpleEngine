<img src="https://github.com/TobiasSpilker/SimpleEngine/blob/main/Images/Layout/Banner_A.png">

# SimpleEngine
SimpleEngine is a rudimentary game engine I'm working on using openTK and c#. This might turn into a game itself later on. Once it is completed enough you can download it from this page. Some code snippets are available and plenty of other information about the engine itself like terrain generation, rendering chunks, storage etc.. This page serves as a hub containing all the information about the program, new updates and where you can actually download it.

<br />

# Simple preview
<img src="https://github.com/TobiasSpilker/SimpleEngine/blob/main/Images/Layout/Preview_GIF.gif">

<br />

# World generation
The most unique function of this engine is it's procedural world generation. The world can be subdivided into multiple levels. These are the following:
1. Tiles - A tile contains an asset {tree, grass, rocks, etc...} (1 tile is 20 units)
2. Chunks - Contains multiple tiles (size can be changed but starts with 10X10 tiles)
3. Loaded chunks - Based on the players location and their render distance a number of chunks will be loaded (just beyond the render distance)
4. QuadValues[] - Stores all the tile values of the entire world in string format, this is completely constructed when starting a new world (size can be changed)

<br />

_CODE SNIPPET FOR WORLD GENERATION:_ <br />
[a link](https://github.com/TobiasSpilker/SimpleEngine/blob/main/Code%20Snippets/WorldGeneration/QuadValues.cs)

_EXAMPLE IMAGE:_
