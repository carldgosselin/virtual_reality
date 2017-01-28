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

The thirds sketch displays the general layout of the instructional panels...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/055 - Instructional Panel sketch.jpg" width="500">
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
**Response:** <br>
1. It's pretty fuzzy. <br>
2. Looks like I'm standing on a dock looking down at some sort of room.<br>
**Outcome:**  
1. To decrease "fuzziness": updated text with sans-serif font style.  Created text via the Canvas component as opposed to the "Text Mesh" component. <br>
2. No changes required for the elevated feeling.  It is intended for the viewer to feel elevated for the "overview" experience.<br>

**Question: What do you think is the intent of this scene?**<br>
**Response:** <br>
3. Looks like I'm looking at a few booths but they are empty. <br>
4. The body language of the people seem hostile.  They don't look relaxed.  <br>
5. What is DOF 3?  I can barely read the signs.<br>
**Outcome:**  
3. The booths will soon be filled with videos and posters <br>
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

<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/071 - Early Design - Booths.png" width="600">
</p>

**User 1**<br>

**Question: Please describe what you see?**<br>
**Response:** <br>
1. I see a conference of some sort. <br>
2. There is nobody working in the booths. <br>
**Outcome:**  
1. No changes required. <br>
2. Removed chair in booth 1 and replaced it with Luke Skywalker.

**Question: Please look at the first booth called "My favorite VR experience". Is it easy to view?**<br>
**Response:** <br>
3. The "lightblade VR" sign looks a little blurry but ok. <br>
4. Why the yellow background?  Maybe use grey or blue. <br>
5. The chair seems too orderly.  Should someone be working at the booth? <br>
**Outcome:** <br>
3. I changed the image setting from "default" to "sprite" and then dragged the image on scene.  Looks a lot crisper. <br>
4. Will attempt to change to grey or blue background. <br>
5. Removed chair in booth 1 and replaced it with Luke Skywalker. <br>

**Question: Tell me how tall you feel at the booth level?**<br>
**Response:** Compared to the chair, I feel quite tall.  The chair should be scaled down.<br>
**Outcome:**  Removed chair in booth 1 and replaced it with Luke Skywalker. <br>

**Question: Please tell me what you would expect to learn at this booth?**<br>
**Response:** I expect to learn something about this "Lightblade VR" game. <br>
**Outcome:** No changes required.<br>


**Question: What type of audio and video could accompany this booth?**<br>
**Response:** I feel there should be a person at the booth beckoning me.<br>
**Outcome:** Removed chair in booth 1 and replaced it with Luke Skywalker.  He can beckon anyone.<br>

**Question: Anything else you would like to share?  Any questions you were expecting that I didn't ask?**<br>
**Response:** No. <br>
**Outcome:** No changes required.<br>

Early design of the Instructional Panels...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/080 - Early Design - Instructational Panels.png" width="600">
</p>

**User 1**<br>

**Question: Please describe what you see near the roof of the arena?**<br>
**Response:** I see the instructions and the sponsors <br>
**Outcome:**  No changes required. <br>

**Question: Do the panels provide sufficient information for you to know what to do?**<br>
**Response:** Yes. <br>
**Outcome:**  No changes required. <br>

**Question: Are the location of the instructional panels appropriate?**<br>
**Response:** Yes, they seem appropriate. <br>
**Outcome:**  No changes required. <br>

**Question: What questions come to mind after reading the instructional panels?**<br>
**Response:** How come I can't click on the booths yet?<br>
**Outcome:**  The booths will be clickable in the near future. <br>

**Question: Anything else you would like to share?  Any questions you were expecting that I didn't ask?**<br>
**Response:** I like the Luke Skywalker picture.  You should make the guy in the blue pants and red hair breakdance. <br>
**Outcome:** No changes required. <br>

Design Updates...
<p align="center">
<img src="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/documentation/090 - Updated Design - Main Hall.png" width="600">
</p>


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

## Additional User testing

I conducted user testing early and frequently to minimize the scale of changes to the application. 
I made an attempt to "fail fast" so that the required changes stayed small.  I conducted four rounds of user testing for this application.


### User testing - Navigation - starting location, booth locations and viewing angles
[click <a target="_new" href="">here</a> to view the "movement" video used for user testing on youtube]

**User 1**<br>
**Question: How do you feel about the starting location of this app?**<br>
**Response:** The Starting location if fine.  Feels like I'm floating above the conference.  I still feel like this app is a little to blurry thought.<br>
**Outcome:** No changes.  I don't think there is much I can do about the "blurry" comment.  This would require a hardware upgrade.<br>

**Question: Now try to navigate to the first booth on the left.  How did you do?**<br>
**Response:** I did it. Seems pretty intuitive.
**Outcome:** No changes required.<br>

**Question: Have a look at the first booth.  How is your viewing experience?**<br>
**Response:** It looks good.  I see some sort of movie and sound. <br>
**Outcome:** No changes required.<br>

**Question: Try to navigate away from the first booth.  Can you describe this experience?**<br>
**Response:** It was easy. Controls are at your feet and you can easily see the it.<br>
**Outcome:** No changes required. <br>

**Question: Please go ahead and navigate to the others booths.  Please describe your experience in doing so.**<br>
**Response:** Navigating to the other booths is fine.  Don't mind it all.<br>
**Outcome:** No changes required.<br>


### User testing - Final product

**Question: What do you think is the first step in this game?**<br>
**Response:** <br>
**Outcome:** <br>

Action:  Please go ahead and click on a booth number.

**Question: How did you feel about the speed of movement to the booth?**<br>
**Response:** <br>
**Outcome:** <br>

Action:  Please have a look at the booth.

**Question: How did you feel about the booth itself?**<br>
**Response:** <br>
**Outcome:** <br>

Action:  Please navigate to the other booths.

**Question: How was your experience visiting the other booths?**<br>
**Response:** <br>
**Outcome:** <br>

**Question: Anything else you would like to share about this virtual experience?**<br>
**Response:** <br>
**Outcome:** <br>


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

Click <a href="https://github.com/carldgosselin/virtual_reality/blob/master/Project-5-VR-Gallery/build">here</a> and move the VR-Gallery apk file onto your favorite Android device and enjoy the experience.





