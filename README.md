# Games Engines 1 Assignment - Infinite Dragon Coin Flyer
Name: Adrian Borkowski

Student Number: C17384436

Class Group: DT211C/4


# Description of the project

Within this project, you take control of a dragon model and collect infininitely generated coins across an infinitely generated mountain pass, which in turn adds to your score.

# Instructions for use

Here are the base instructions to play the game:

W - Move forward
S - Move backwards
A - Move left
D - Move right

E - Roll left
Q - Roll right

Left Ctrl - Fly down
Space - Fly up

Mouse - Point the mouse in whichever direction you would like the dragon to fly (no clicking required)

R - Restart the game

# How it works

The project firstly uses PerlinNoise on a plane which contains a mountain-like .jpg file already attached to it. This gives the mountain & valley feel to the plane, which was exactly the feel that was required. That plane had been given the GenerateTerrain code script, which uses meshes to create the PerlinNoise function. 

Next, the project uses infinite procedural terrain generation on both the plane that is underneath the dragon and the coins alike. There is a script called GroundSpawner, which contains a for loop that allows the SpawnTile function to be called 20 times whenever the program starts. The SpawnTile function itself instantiates quaternions, as well as spawning the actual tiles. 

Furthermore, there is a GroundTile script which calls the SpawnTile function within the GroundSpawner script as well as destroying the previously spawned object after two seconds have passed. Both of these actions are called only if there is a GameObject (the character model for example) hitting the collision box of the plane. 

As previously mentioned, there are also coins featured within this game that are spawned infinitely. To begin with this, there was a cylinder created and tranformed into the shape of a coin. There was a material added, which gave the coin it's colour. After that, there was turn speed and transforming rotation code used for the coin within the Coin script. Next, the spawning of the coin was added within the GroundTile script. This code allowed the coin to randomly spawn anywhere within the X and Z axis in the collider as we had already configured it's Y axis in order to place it above the terrain. A piece of code was also implemented which dictated that if the Gameobject of the player interracted with the coin, the coin would be destroyed and the Score count would go up by one. This score was configured as text on the screen to show the player how many coins they have gotten.

In regards to the player, I had started off with creating a cylinder in order to create a base character for the player to move with. I had scaled it down and stacked a pre-created dragon model from the Unity Asset Store, which allows the player to control the dragon model. The main camera is placed behind the dragon model, allowing the player to constantly see the dragon model upright and follow it anywhere. 

There was also a character controller that was implemented, which had float speeds of the movement, look speed and roll speed configured. The script assigns the speeds and the way in which the dragon model transforms to the configured axes in Unity (Horizontal, Vertical) as well as the axes that I had to create manually (Hover and Roll).

# References

https://www.youtube.com/watch?v=xFhScBZdXxg&t=293s
https://www.youtube.com/watch?v=-ffFpWtS4Cg
https://www.youtube.com/watch?v=J6QR4KzNeJU
https://www.youtube.com/watch?v=dycHQFEz8VI&t=1620s
https://assetstore.unity.com/packages/2d/textures-materials/sky/classic-skybox-24923
https://assetstore.unity.com/packages/3d/characters/animals/free-low-polygon-animal-110679

# What I am most proud of in the assignment

From doing the assignment, I am most proud in being able to infinitely generate the tiles and to make the game work even better than I originally planned. The terrain for the mountain pass looks far better than I thought I would be able to make it and I'm very happy with the game's current position. Due to some machine constraints, I was not able to implement the sides (taller mountain pass) as my game would start to lag heavily. This is something that I would like to work on if I was to ever revisit the project.

# Proposal submitted earlier

# Name: Adrian Borkowski
# Student Number: C17384436
# Class Group: DT211C/4

**Proposal Idea**: Within this assignment, I would like to create a game in which the user takes control of a serpent-like dragon. In this game, you control some movements for the dragon and as you fly through the sky, an infinite procedurally generated range of mountains continues on both sides with the same happening underneath but including trees and rivers.

A few references for my assignment can be found here:

https://www.youtube.com/watch?v=-W7zt8181Zo
https://www.youtube.com/watch?v=6moaBkJY1Yw
https://www.youtube.com/watch?v=fMGTiYZ0EHY




