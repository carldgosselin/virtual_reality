<p align="right">
Carl Gosselin
</p>

# VR Gallery - SUMMARY AND PROCESS OF WORK

## Introduction

I built a confidence-boosting application as part of Udacity's Virtual Reality Development Nanodegree.  This application took me about 3 weeks to complete (design, test, build and repeat).
I took a considerable amount of time designing and testing the application early in the process so that I could "fail fast" and make incremental changes throughout the process.
I took the time to conduct multiple rounds of user testing to get early feedback on the virtual environment, the instructional panels, movement from one video to another, and testing the final product.
The multiple rounds of user testing helped in keeping the bugs and scale of changes to a minimum.  The final product is a virtual space with X video booths surrounding the viewer and boosting his/her confidence.  


## Screenshots

<p align="center">
<img src="pics/000 - Overall.png">
</p>
<p align="center">
<br>
[click <a target="_new" href="https://youtu.be/KByXvsmKrW8">here</a> to view motivational video/application on youtube]
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
<a href="documentation/040 - LetsGetMotivated! Storyboard.pdf">
<img src="pics/storyboardSample.png">
</a>
<br>
You can view the other storyboard visuals <a href="documentation/040 - You The Man! Storyboard.pdf">here</a>.
</p>

### User testing - Environment - Google Cube

**User 1** <br>

**Question: Please describe what you see** <br>
**Response:** <br>
1. Looks like I'm standing in some sort of room. <br>
2. I feel kinda small.<br>

**Outcome:**  <br>
1. No changes required <br>
2. Increased the height of the camera to make the viewer feel a little taller in the room. <br>

**Question: What do you think is the intent of this scene?** <br>
**Response:** <br>
3. I'm seeing an arrow that goes up.  Looks like I have to click on it. <br>
4. I'm not sure what this application is all about.  <br>

**Outcome:** <br>
3. No changes required. <br>
4. I added some verbiage to highlight the purpose of this experience which is motivating someone before a big event. <br>

**Question: How tall you feel when looking down at the scene?** <br>
**Response:** I feel small in this scene. <br>
**Outcome:**  I raised the height of the viewer gameobject to make the viewer feel a little taller. <br>

**Question: Can you describe the mood of the environment?** <br>
**Response:** I don't know.  Not sure what to think of this. <br>
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
<img src="pics/010 - Start.png" width="600">
</p>
<p align="center">
The viewer clicks on the arrow to move up on stage in front of a cheering crowd.
</p>

After...
<p align="center">
<img src="pics/020 - On Stage.png" width="600">
</p>
<p align="center">
On stage, the user clicks on the rotating cube to move forward.
</p>

After...
<p align="center">
<img src="pics/030 - Choice.png" width="600">
</p>
<p align="center">
The viewer is then presented with a choice to jump to space or go back underground to the Google cube.
</p>

After...
<p align="center">
<img src="pics/040 - In Space.png" width="600">
</p>
<p align="center">
In space, the viewer to look at motivational videos before landing back to earth.
</p>


### User testing outcomes and iterations

Two major changes:  Viewing height and sound consistency.  Testing the application early and frequently kept the bugs and changes small and incremental.  
It helped mitigate large mistakes that would have taken a lot of time to resolve if discovered further down the road.
With early user testing, I was able to adjust the height of the game and the speed of movement early in the process.

## How to install

Click <a href="build/">here</a> and move the Let's Get Motivated apk file onto your favorite Android device and get pumped up for your next event.





