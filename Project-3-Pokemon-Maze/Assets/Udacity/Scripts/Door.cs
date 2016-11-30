using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	bool locked = true;

	// Door sounds
	public GameObject doorLockedSound;
	public GameObject doorUnlockedSound;

	// Boolean for key collection
	public bool isCollected = false;
		
	void Update() {
        // If the door is unlocked and it is not fully raised
		if (locked == false && transform.position.y < 22) {
			// Animate the door raising up
			transform.Translate (0, 10 * Time.deltaTime, 0, Space.World);
		}
    }

	public void Unlock()
	{
		// You'll need to set "locked" to true here
		// Carl's comment ->  this method will be called once key is found. Therefore update locked to false

		if (isCollected == true) {
			locked = false;
			// Play "unlock" sound
			Instantiate (doorUnlockedSound, transform.position, Quaternion.identity);

		} else {
			//Play "locked" sound
			Instantiate (doorLockedSound, transform.position, Quaternion.identity);
		}
	}

	public void keyCollected()
	{
		// Update isCollected boolean
		isCollected = true;
	}
}
