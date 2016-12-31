<p align="right">
Carl Gosselin
</p>

## PUZZLER - SUMMARY AND PROCESS OF WORK

### Introduction

<p align="center">
<img src="documentation/070 - Environment snapshot.png" width="500">
<br>[click <a target=_blank href="https://youtu.be/iXAmVSXLY1w">here</a> to view video of game on youtube]
</p>

I built this game as part of Udacity's Virtual Reality Development Nanodegree.  The game took me about 1 week to complete (design, test, build and repeat).
I took a considerable amount of time designing and testing the application early in the process so that I could "fail fast" and make incremental changes throughout the process.
I took the time to conduct 5 rounds of user testing for the environment, reviewing the start and restart panels, game movement, and testing the final product.
The 5 rounds of user testing helped in keeping the scale of changes to a minimum.
The final product is a virtualized version of the "simon says" game.  The player observes the flashing orbs and tries to match the sequence. 

The rest of the document will explain the process I underwent to complete the virtual video game as shown above.

### Statement of purpose
Puzzler is a mobile VR application for new VR users which challenges them to solve a familiar type of puzzle in a new way.

### Personas

Below are the personas I captured for playing the Puzzler game.

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

### User testing

I conducted user testing early and frequently to minimize the scale of changes to the application. 
I made an attempt to "fail fast" so that the required changes stayed small.  I conducted four rounds of user testing for this application.

### 1.  User testing - environment

**User 1**<br>
**1. Tell me how tall you feel in this game?**<br>
It feels like I'm looking up at the 5 balls in front of me.  So I feel a little short in this game

**2. Tell me about your experience inside this application?**<br>
This is a really cool virtual space.  I like it.

**3. Can you describe the mood of the environment?**<br>
I feel like I'm in the mediavel times.  Very eery.


**User 2**<br>
**1. Tell me how tall you feel in this game?**<br>
I feel shorter than I usually am.  

**2. Tell me about your experience inside this application?**<br>
This is a very cool room.  Although it feels a bit choppy and may get dizzy if I keep playing for a few more minutes.

**3.  Can you describe the mood of the environment?**<br>
Very medieval!


### 2.  User testing - start and restart panels

**User 1**<br>
**1. Are you seeing a panel of some sort?**<br>
yes, I see a big black box

**2. How big does the panel feel to you?**<br>
It feels very big.

**3. What do you think the panel is for?**<br>
It looks like the panels is used to start a game.

**4. What do you think happens when you click on the button?**<br>
I think the panel goes away and some sort of game starts.

**5. Go ahead and click the button.  Can you describe the second panel?**<br>
It looks like the second panel is used to restart the game.  At this point, the user was confused as there was no game played.
I informed the user that I was only user testing the panels at this point. 


### 3.  User testing - movement<br>

**User 1**<br>
Action:  Please hit the start button.

**1. How did you feel about the speed of movement into the room?**<br>
It felt a little too fast.  It was a bit disorienting.  I would like it to be a little slower.
I was surprised when I started moving.

**2. Did you feel a little sick as you were moving?**<br>
Yes, I felt a little sick.

**3. Do you have anything else to add about the movement or anything else?**<br>
Yes, I get stuck outside the building if I click the "restart" button from inside the room.

note:  the above is a bug where the user can click the "restart" button from inside the game room. <br>
Action:  the "restart" button needs to be inactive until the player is outside the building.


### 4.  User testing - Final product
**TBD**


### User testing outcomes and iterations

Testing the application early and frequently resulted in small and incremental adjustments to the application.  
It helped mitigate large mistakes that would have taken a lot of time to resolve if discovered further down the road.
With early user testing, I was able to adjust the height of the game and the speed of movement early in the process.

### Breakdown of the final piece

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

Thanks for reading!


