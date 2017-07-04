<p align="right">
Carl Gosselin
</p>

# VR Gallery - SUMMARY AND PROCESS OF WORK

## Introduction

I built a confidence-boosting application as part of Udacity's Virtual Reality Development Nanodegree.  This application took me about X weeks to complete (design, test, build and repeat).
I took a considerable amount of time designing and testing the application early in the process so that I could "fail fast" and make incremental changes throughout the process.
I took the time to conduct multiple rounds of user testing to get early feedback on the virtual environment, the instructional panels, movement from one video to another, and testing the final product.
The multiple rounds of user testing helped in keeping the bugs and scale of changes to a minimum.  The final product is a virtual space with X video booths surrounding the viewer and boosting his/her confidence.  


## Screenshots

<p align="center">
<img src="pics/000 - Overall.png">
</p>
<p align="center">
<br>
[click <a target="_new" href="https://youtu.be/KByXvsmKrW8">here</a> to view motivational video/application]
</p>

## Statement of purpose
This application is a mobile VR application for people that want to engage in a confidence boosting activity before entering a meeting or attending an social event.

## The Process

### Choosing the ideal persona

For the design of this game, I chose my wife, Andrea, as the ideal persona.

<p align="center">
<img src="documentation/010 - Identify Ideal Persona.png" width="600">
</p>

### Choosing the achievements (application features) from Udacity documentation

This capstone project requires the selection of many "achievements" (application features) to be included in the final application to be considered complete. <br>
You can find the complete list of Udacity "achievements" in this <a href="documentation/030 - Achievements - Udacity Capstone Requirements.docx">document</a>. <br>
You can review the "achievements" that I've selected for this project <a href="documentation/031 - Identify Achievements for Capstone Project.md">here</a>.<br>


### Sketches

I sketched the application visuals using a 360 storyboard template...
<p align="center">
<a href="documentation/040 - You The Man! Storyboard.pdf">
<img src="pics/storyboardSample.png">
</a>
<br>
You can view the other storyboard visuals <a href="documentation/040 - You The Man! Storyboard.pdf">here</a>.
</p>

### User testing - Environment - Google Cube

**User 1**<br>

**Question: Please describe what you see**<br>
**Response:**
1. Looks like I'm standing in some sort of room. <br>
2. I feel kinda small.<br>
<br>
**Outcome:**  <br>
1. No changes required <br>
2. Increased the height of the camera to make the viewer feel a little taller in the room.<br>
<br>
**Question: What do you think is the intent of this scene?**<br>
**Response:** <br>
3. I'm seeing an arrow that goes up.  Looks like I have to click on it. <br>
4. I'm not sure what this application is all about.  <br>
<br>
**Outcome:**  
3. No changes required. <br>
4. I added some verbiage to highlight the purpose of this experience which is motivating someone before a big event. <br>

**Question: How tall you feel when looking down at the scene?**<br>
**Response:** I feel small in this scene.<br>
**Outcome:**  I raised the height of the viewer gameobject to make the viewer feel a little taller.<br>

**Question: Can you describe the mood of the environment?**<br>
**Response:** I don't know.  Not sure what to think of this.<br>
**Outcome 1:** Added motivational verbiage and background sound (heartbeat and fans cheering) <br>
**Outcome 2:** I reduced the background sound of fans cheering to make it feel more realistic of being inside a room. <br>


### User testing - Environment - On Stage

**User 1**<br>

**Question: Please describe what you see?**<br>
**Response:** <br>
1. I see I'm at some sort of concert with fans cheering. <br>
2. I see a rotating cube.  Not sure what to to. <br>
**Outcome:**  
1. No changes required. <br>
2. I added animation to the cube.  The cube now changes color and changes in scale using a script. User now feels like they should click on it.

**Question: Tell me how tall you feel on stage?**<br>
**Response:** It feel good.  Like everyone is cheering for me.  However, I feel small here too.<br>
**Outcome:**  I raised the viewer gameobject to make the viewer feel a little but taller. <br>

**Question: Please tell me what you would expect to do next?**<br>
**Response:** Click on the rotating cube. <br>
**Outcome:** No changes required.<br>

**Question: Anything else you would like to share?  Any questions you were expecting that I didn't ask?**<br>
**Response:** No. <br>
**Outcome:** No changes required.<br>


### User testing - Environment - In Space

**User 1**<br>

**Question: Please describe what you see in space?**<br>
**Response:** I see video panels <br>
**Outcome:**  No changes required. <br>

**Question: Do you know what to do here?**<br>
**Response:** Yes. Looks like I can watch videos.  I guess they are motivational videos to watch before I go back to earth.<br>
**Outcome:**  No changes required. <br>

**Question: Are the location of the video panels appropriate?**<br>
**Response:** No, I really have to look up to watch the videos <br>
**Outcome:**  I lowered the videos for a more confortable viewing experience. <br>

**Question: Anything else you would like to share?  Any questions you were expecting that I didn't ask?**<br>
**Response:** Yes, some of the videos are louder than others.  Can you make these more consistent. <br>
**Outcome:** I recalibrated the audio of videos. <br>

### User testing - Navigation - starting location, on stage and in space

**User 1**<br>
**Question: How do you feel about the starting location of this app?**<br>
**Response:** It good.  Thinking about it, it's sort of a prep room to reflect before going on stage to the fans. <br>
**Outcome:** No changes. <br>

**Question: What do you think you need to do next?**<br>
**Response:** I think I should click on the arrow to go up.
**Outcome:** No changes required.<br>

**Question: Now that you are on stage.  How is your viewing experience?**<br>
**Response:** It looks good.  It's a little dark in some parts of the crowd but ok. <br>
**Outcome:** I added a few more lights to light up the crowd.<br>

**Question: What do you think is your next step?**<br>
**Response:** I think I will click on the rotating cube.<br>
**Outcome:** No changes required. <br>

**Question: What is your next step after this?**<br>
**Response:** Looks like I have a choice to go into space or go underground.<br>
**Outcome:** No changes required.<br>


### Breakdown of the final piece (or SOP)

The experience begins with...
<p align="center">
<img src="pics/dancingbear.gif">
</p>
<p align="center">
The user can navigate to one of the X available video screens.
</p>

After...
<p align="center">
<img src="pics/dancingbear.gif">
</p>
<p align="center">
Placeholder.
</p>

After...
<p align="center">
<img src="pics/dancingbear.gif">
</p>
<p align="center">
Placeholder.
</p>


## Additional User testing

I conducted user testing early and frequently to minimize the scale of changes to the application. 
I made an attempt to "fail fast" so that the required changes stayed small.  I conducted four rounds of user testing for this application.


### User testing - Navigation - starting location, booth locations and viewing angles

**User 1**<br>
**Question: How do you feel about the starting location of this app?**<br>
**Response:** ....<br>
**Outcome:** ....<br>

**Question: Now try to navigate to the first booth on the left.  How did you do?**<br>
**Response:** ...
**Outcome:** ...<br>

**Question: Have a look at the first booth.  How is your viewing experience?**<br>
**Response:** ... <br>
**Outcome:** ...<br>

**Question: Try to navigate away from the first booth.  Can you describe this experience?**<br>
**Response:** ...<br>
**Outcome:** ... <br>

**Question: Please go ahead and navigate to the others booths.  Please describe your experience in doing so.**<br>
**Response:** ...<br>
**Outcome:** ...<br>


### User testing - Final product

**Question: What do you think is the first step in this application?**<br>
**Response:** ...<br>
**Outcome:** ...<br>

Action:  Please go ahead and click on a booth number.

**Question: How did you feel about the speed of movement to the booth?**<br>
**Response:** ...<br>
**Outcome:** ...<br>

Action:  Please have a look at the booth.

**Question: How did you feel about the booth itself?**<br>
**Response:** ...  <br>
**Outcome:** ...<br>

Action:  Please navigate to the other booths.

**Question: How was your experience visiting the other booths?**<br>
**Response:** ...<br>
**Outcome:** ...<br>

**Question: Anything else you would like to share about this virtual experience?**<br>
**Response:** ...<br>
**Outcome:** ...<br>


### User testing outcomes and iterations

Testing the application early and frequently kept the bugs and changes small and incremental.  
It helped mitigate large mistakes that would have taken a lot of time to resolve if discovered further down the road.
With early user testing, I was able to adjust the height of the game and the speed of movement early in the process.


## Conclusion

This assignment made me realize the importance of establishing a repeatable process for creating a virtual environment.  
It made evident the importance of user testing components of the game early to "fail fast".  
Getting the scale of the game right is important in the early stages of development as re-scaling at the end of the development process can take a lot more time and resources to fix.  
In virtual reality, the scale and speed of movement are core attributes to a good experience.

## How to install

Click <a href="build/">here</a> and move the VR-Gallery apk file onto your favorite Android device and get pumped up for your next event.





