<p align="right">
Carl Gosselin
</p>

# VR Gallery - SUMMARY AND PROCESS OF WORK

## Introduction

I built a VR gallery as part of Udacity's Virtual Reality Development Nanodegree.  This application took me about 1 week to complete (design, test, build and repeat).
I took a considerable amount of time designing and testing the application early in the process so that I could "fail fast" and make incremental changes throughout the process.
I took the time to conduct 4 rounds of user testing to get early feedback on the gallery environment, the start and exit panels, movement from one booth to another, and testing the final product.
The 4 rounds of user testing helped in keeping the bugs and scale of changes to a minimum.  The final product is a virtual gallery with five booths showcasing the state of the VR industry in year 2016 and 2017.  


## VR Gallery - WORK IN PROGRESS

<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/000 - WIP%20- dancingbear.gif">
</p>

In the development of this application, I took special precaution around the speed of movement to minimize any nauseating discomfort.
A user test was specifically conducted to ensure maximum comfort in navigating through a virtual space.

## Statement of purpose
This application is a mobile VR application for new VR users and educates them about the state of the VR industry in year 2016 and 2017.

## The Process

### Choosing the ideal persona

For the design of this game, I chose my wife, Andrea, as the ideal persona.

<p align="center">
<img src="documentation/010 - Identify Ideal Persona.png" width="600">
</p>

### Sketches

The first sketch displays the main hall where all booths can be seen in a single view...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/040%20-%20Main%20Hall%20sketch%20-%20lowfi.jpg" width="500">
<br>
Main panel:  "Welcome. Click on a booth to visit" <br>
Left side panel:  Udacity logo <br>
Right side panel: Unity logo <br>
</p>

The second sketch displays the general layout of the booths...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/050%20-%20Booth%20sketch%20-%20lowfi.jpg" width="500">
</p>

### Early design

Early design of the main hall...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/060 - Early Design - Main Hall.png" width="600">
</p>

<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/061 - Early Design - Main Hall.png" width="600">
</p>

### User testing - Environment - Main Hall

**User 1**<br>

**Question: Please describe what you see**<br>
**Response:**
1. It's pretty fuzzy. <br>
2. Looks like I'm standing on a dock looking down at some sort of room.<br>  
**Outcome:**  
1. Updated text with sans-serif font style.  Created text via the Canvas as opposed to the Text feature <br>
2. No changes required for the elevated feeling.  It is intended for the viewer to feel elevated for the "overview" experience.<br>

**Question: What do you think is the intent of this scene?**<br>
**Response:** 
3. Looks like I'm looking at a few booths but they are empty. <br>
4. The body language of the people seem hostile.  They don't look relaxed.  <br>
5. What is DOF 3?  I can barely read the signs.<br>
**Outcome:**  
3. No changes.  The booths will remain empty for this project.  The booths will soon be filled with videos and posters <br>
4. "Idle" animation activated to make the crowd seem less hostile. <br>
5. As previously discussed, updated the crispness of the text with a sans-serif font (arial)

**Question: How tall you feel when looking down at the scene?**<br>
**Response:** I feel bigger than everyone else.<br>
**Outcome:**  No changes required.<br>

**Question: Can you describe the mood of the environment?**<br>
**Response:** I don't know.  Again, the people I see appear to be impatient (body language)<br>
**Outcome:** Added "Idle" animation to the audience to make them appear less hostile.  Also, added instructional panels for clarity of purpose and navigation. <br>

Early design of the booths...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/070 - Early Design - Booths.png" width="600">
</p>

**User 1**<br>
**Question: Tell me how tall you feel at the booth level?**<br>
**Response:** TBD...<br>
**Outcome:**  TBD...<br>

**Question: Tell me about your experience at booth level?**<br>
**Response:** TBD...<br>
**Outcome:** TBD...<br>

**Question: Can you describe the mood at the booth level?**<br>
**Response:** TBD...<br>
**Outcome:** TBD...<br>

### Breakdown of the final piece (or SOP)

The experience begins with...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/000 - WIP%20- dancingbear.gif">
</p>

After...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/000 - WIP%20- dancingbear.gif">
</p>

After...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/000 - WIP%20- dancingbear.gif">
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

**Question: What do you think is the first step in this game?**<br>
**Response:**  Looks like I have to click on the Start button.  I like that you pushed back the panel.  It's not too big anymore. <br>
**Outcome:** None required.<br>

Action:  Please go ahead and click on the Start button.

**Question: How did you feel about the speed of movement into the dungeon room?**<br>
**Response:** The speed is nice and slow.  I didn't feel any discomfort at all.  This is much better than last time.<br>
**Outcome:** None required.<br>

Action:  Please play the game.

**Question: How did you feel about the game itself?**<br>
**Response:** The game was good.  I like how the orbs lit up and sparkled.  It made it easy to remember the sequence.<br>
**Outcome:** None required.<br>

**Question: How did you feel about the speed of movement outside the room?**<br>
**Response:** It felt good.  Same as entering the room.<br>
**Outcome:** None required.<br>

**Question: Are you seeing anything outside?**<br>
**Response:** Yes, I'm seeing a restart panel.  It's a good distance and easy to read.<br>
**Outcome:** None required.<br>


### User testing outcomes and iterations

Testing the application early and frequently kept the bugs and changes small and incremental.  
It helped mitigate large mistakes that would have taken a lot of time to resolve if discovered further down the road.
With early user testing, I was able to adjust the height of the game and the speed of movement early in the process.


## Conclusion

This assignment made me realize the importance of establishing a repeatable process for creating a virtual game.  
It made evident the importance of user testing components of the game early to "fail fast".  
Getting the scale of the game right is important in the early stages of development as re-scaling at the end of the development process can take a lot more time and resources to fix.  
In virtual reality, the scale and speed of movement are core attributes to a good experience.

## How to install

Click <a href="https://github.com/carldgosselin/virtual_reality/blob/master/Project-4-Puzzler/build">here</a> and move the Puzzler apk file onto your favorite Android device and enjoy the experience.





