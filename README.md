# Computer Graphics Course Project
 
Attributions:
- Duckdeer by "davs27" on SketchFab: https://skfb.ly/oT8D7
- All of the shader code was taken from the tutorials and lectures

Controls:
- A and D to move
- Space to jump
- Alt+F4 to quit (sorry)

Goal: Reach the flag without going off the screen!

Project presentation: 

## Explanations:

Requirements:
- Toggling of lighting was unable to be implemented properly as online documentation appears to state that I need one material for lit and one for unlit, and I am unable to get material switching working properly (improper implementation can be done using the U key during runtime)

 Improvements:
- LUT was finally implemented by combining the provided glass shader and the provided LUT shader
- Grass shader now tiles!
  <img width="1920" height="1020" alt="image" src="https://github.com/user-attachments/assets/7dcaf6a1-1939-4d32-b34d-2696e5f1f342" />


Texturing: 
- Toggling of texturing half works; I am able to toggle the texturing off, but toggling it back on doesn't work and I don't know why (can be toggled using the T key)

Visual effects:
- Glass shader is the same as the one from class, but with inverted colors
  <img width="360" height="334" alt="image" src="https://github.com/user-attachments/assets/9ad187b8-d7ca-41e4-9704-f3d4b4bcc525" />
- Decals were implemented as shown in class
- Scrolling textures were implented using Tan instead of Sine, and have scroll based on the players position (toggled using the Y key)
