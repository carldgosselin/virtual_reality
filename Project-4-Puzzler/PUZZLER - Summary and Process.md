<p align="right">
Carl Gosselin
</p>

# PUZZLER - SUMMARY AND PROCESS OF WORK

## Introduction

I built a game called PUZZLER as part of Udacity's Virtual Reality Development Nanodegree.  The game took me about 1 week to complete (design, test, build and repeat).
I took a considerable amount of time designing and testing the application early in the process so that I could "fail fast" and make incremental changes throughout the process.
I took the time to conduct 4 rounds of user testing to get early feedback on the dungeon environment, the start and restart panels, game movement, and testing the final product.
The 4 rounds of user testing helped in keeping the bugs and scale of changes to a minimum.  The final product is a virtualized version of the "simon says" game.  
In other words, the player observes the sequence of flashing dungeon orbs and tries to replicate the sequence.  

**Caution**: Failing to replicate the sequence of flashing dungeon orbs may cause frustration and embarrassment to you and your immediate family.  Play at your own risk.  


## PUZZLER

<p align="center">
<img src="documentation/070 - Environment snapshot.png" width="500">
<br>[click <a target="_new" href="https://youtu.be/iXAmVSXLY1w">here</a> to view video of game on youtube]
</p>

In the development of this game, I took special precaution around the movement and speed of the game to minimize any nauseating discomfort.
A user test was specifically conducted to ensure maximum comfort in navigating through a virtual space.

## Statement of purpose
Puzzler is a mobile VR application for new VR users which challenges them to solve a familiar type of puzzle in a new way.

## The Process

### Choosing the ideal persona

For the design of this game, I chose my daughter, Isabelle, as the ideal persona.

<p align="center">
<img src="documentation/030 - Create personas.png" width="600">
</p>

### Sketches

The first sketch displays the entire game on a single sheet of paper...
<p align="center">
<img src="documentation/050 - PUZZLER low-fi sketch.jpg" width="500">
</p>

The second sketch displays a rough outline of the start panel...
<p align="center">
<img src="documentation/090 - Start game UI.jpeg" width="500">
</p>

The third sketch displays a rough outline of the restart panel...
<p align="center">
<img src="documentation/100 - Restart game UI.jpeg" width="500">
</p>


### Early design

Early design of the dungeon...
<p align="center">
<img src="documentation/060 - early design.png" width="500">
</p>

Early design of the dungeon...
<p align="center">
<img src="documentation/065 - early design.png" width="500">
</p>

Early design of the start and restart panels...
<p align="center">
<img src="documentation/110 - start and restart UI.png" width="500">
</p>

## User testing

I conducted user testing early and frequently to minimize the scale of changes to the application. 
I made an attempt to "fail fast" so that the required changes stayed small.  I conducted four rounds of user testing for this application.

### 1.  User testing - environment

**User 1**<br>
**Question: Tell me how tall you feel in this game?**<br>
**Response:** It feels like I'm looking up at the 5 balls in front of me.  So I feel a little short in this game<br>
**Outcome:**  I lowered the 5 dungeon orbs to place the objects at eyesight level (as oppose to looking up).<br>

**Question: Tell me about your experience inside this application?**<br>
**Response:** This is a really cool virtual space.  I like it.<br>
**Outcome:** None required.<br>

**Question: Can you describe the mood of the environment?**<br>
**Response:** I feel like I'm in the mediavel times.  Very eery.<br>
**Outcome:** None required.<br>


### 2.  User testing - start and restart panels

**User 1**<br>
**Question: Are you seeing a panel of some sort?**<br>
**Response:** yes, I see a big black box<br>
**Outcome:** None required.<br>

**Question: How big does the panel feel to you?**<br>
**Response:** It feels very big.<br>
**Outcome:** I moved the camera back a few meters to reduce the size of the panel.<br>

**Question: What do you think the panel is for?**<br>
**Response:** It looks like the panel is used to start a game.<br>
**Outcome:** None required.<br>

**Question: What do you think happens when you click on the button?**<br>
**Response:** I think the panel goes away and some sort of game starts.<br>
**Outcome:** None required.<br>

**Question: Go ahead and click the button.  Can you describe the second panel?**<br>
**Response:** It looks like the second panel is used to restart the game.  
**Outcome:** None required.  However, the user was confused as there was no game played.<br>
I informed the user that I was only user testing the panels at this point. <br>


### 3.  User testing - movement
[click <a target="_new" href="https://youtu.be/4UHACWHgfoU">here</a> to view the "movement" video used for user testing on youtube]

**User 1**<br>
Action:  Please hit the start button.

**Question: How did you feel about the speed of movement into the room?**<br>
**Response:** It felt a little too fast.  It was a bit disorienting.  I would like it to be a little slower. I was surprised when I started moving.<br>
**Outcome:** I slowed down the speed of movement between each of the three positions of the game.<br>

**Question: Did you feel a little sick as you were moving?**<br>
**Response:** Yes, I felt a little sick.<br>
**Outcome:** I slowed down the speed of movement between each of the three positions of the game.<br>

**Question: Do you have anything else to add about the movement or anything else?**<br>
**Response:** Yes, I get stuck outside the building if I click the "restart" button from inside the room.<br>
**Outcome:** this is a bug where the user can click the "restart" button from inside the game room. <br>
This was resolved by making the restart panel appear only after the game is won.


### 4.  User testing - Final product
**TBD**


### User testing outcomes and iterations

Testing the application early and frequently kept the bugs and changes small and incremental.  
It helped mitigate large mistakes that would have taken a lot of time to resolve if discovered further down the road.
With early user testing, I was able to adjust the height of the game and the speed of movement early in the process.

## Breakdown of the final piece

The game begins with a UI panel that instructs the player to click the start button...
<p align="center">
<img src="documentation/150 - Start UI screen.png" width="500">
</p>

After clicking the start button, the player is transported inside the dungeon to play the Puzzler game...
<p align="center">
<img src="documentation/070 - Environment snapshot.png" width="500">
</p>

After winning the game, the player is transported outside and is given the choice to play again...
<p align="center">
<img src="documentation/160 - Restart UI screen.png" width="500">
</p>

## Conclusion

This assignment made me realize the importance of establishing a repeatable process for creating a virtual game.
It made evident the importance of user testing components of the game early to "fail fast".  
Getting the scale of the game right is important in the early stages of development as re-scaling at the end of the development process can take a lot more time and resources to fix.
In virtual reality, the scale and speed of movement are core attributes to a good experience.





