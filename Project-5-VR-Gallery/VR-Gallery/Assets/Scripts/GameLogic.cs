using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour { 

	public GameObject player;
	public GameObject eventSystem;
	public GameObject startUI, restartUI;
	public GameObject startPoint, booth1, booth2, booth3, booth4, booth5, booth6;
	public GameObject Booth2Nav;

	// Use this for initialization
	void Start () {
		  
	}

	// Update is called once per frame
	void Update () {

	}

	// Booth selection...
	public void goToBooth1 () {
		iTween.MoveTo (player, booth1.transform.position, 10f);
		//Booth2Nav<Renderer>.enabled = false;


		//   ......Other attempts at hiding objects.........      //
		// Show/hide navigation panel located on the floor.  gameobject and all it's children
		//var renderers = gameObject.GetComponentsInChildren.(booth2);
		//for (var r : Renderer in renderers) {
		//	r.enabled = !r.enabled;
		//}

		//GetComponent()<Renderer>.enabled = false;
		//booth2.activeInHierarchy = false;

		//Booth2Nav.SetActiveRecursively(false);
	}

	public void goToBooth2 () {
		iTween.MoveTo (player, booth2.transform.position, 10f);
	}
	public void goToBooth3 () {
		iTween.MoveTo (player, booth3.transform.position, 10f);
	}
	public void goToBooth4 () {
		iTween.MoveTo (player, booth4.transform.position, 10f);
	}
	public void goToBooth5 () {
		iTween.MoveTo (player, booth5.transform.position, 10f);
	}
	public void goToBooth6 () {
		iTween.MoveTo (player, booth6.transform.position, 10f);
	}


	public void goToStart () {
		iTween.MoveTo (player, startPoint.transform.position, 10f);
	}


	// useful example: iTween.MoveTo (player, playPoint.transform.position, 10f);

	/*public void startPuzzle() { //Begin the puzzle sequence
		//Generate a random number one through five, save it in an array.  Do this n times.
		//Step through the array for displaying the puzzle, and checking puzzle failure or success.
		startUI.SetActive (false);
		eventSystem.SetActive(false);
		iTween.MoveTo (player, playPoint.transform.position, 10f);
		CancelInvoke ("displayPattern");
		InvokeRepeating("displayPattern", 6, puzzleSpeed); //Start running through the displaypattern function
		currentSolveIndex = 0; //Set our puzzle index at 0

	}*/

	/*void displayPattern() { //Invoked repeating.
		currentlyDisplayingPattern = true; //Let us know were displaying the pattern
		eventSystem.SetActive(false); //Disable gaze input events while we are displaying the pattern.

		if (currentlyDisplayingPattern == true) { //If we are not finished displaying the pattern
			if (currentDisplayIndex < puzzleOrder.Length) { //If we haven't reached the end of the puzzle
				Debug.Log (puzzleOrder[currentDisplayIndex] + " at index: " + currentDisplayIndex); 
				puzzleSpheres [puzzleOrder [currentDisplayIndex]].GetComponent<lightUp> ().patternLightUp (puzzleSpeed); //Light up the sphere at the proper index.  For now we keep it lit up the same amount of time as our interval, but could adjust this to be less.
				currentDisplayIndex++; //Move one further up.
			} else {
				Debug.Log ("End of puzzle display");
				currentlyDisplayingPattern = false; //Let us know were done displaying the pattern
				currentDisplayIndex = 0;
				CancelInvoke(); //Stop the pattern display.  May be better to use coroutines for this but oh well
				eventSystem.SetActive(true); //Enable gaze input when we aren't displaying the pattern.
			}
		}
	}*/
	

	// code example....
	/*public void resetPuzzle() { //Reset the puzzle sequence
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", startPoint.transform.position, 
				"time", 4, 
				"easetype", "linear",
				"oncomplete", "resetGame", 
				"oncompletetarget", this.gameObject
			)
		);

		restartUI.SetActive (false);
	}*/


	/*public void resetGame() {
		restartUI.SetActive (false);
		startUI.SetActive (true);
		playerWon = false;
		generatePuzzleSequence (); //Generate the puzzle sequence for this playthrough.  
	}*/


	// code example
	/*public void puzzleSuccess() { //Do this when the player gets it right
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", restartPoint.transform.position, 
				"time", 4, 
				"easetype", "linear",
				"oncomplete", "finishingFlourish", 
				"oncompletetarget", this.gameObject
			)
		);
	}*/

	
	/*public void finishingFlourish() { //A nice visual flourish when the player wins
		//this.GetComponent<AudioSource>().Play(); //Play the success audio
		restartUI.SetActive (true);
		playerWon = true;

	}*/


}