using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	bool locked = true;
		
	void Update() {
        // If the door is unlocked and it is not fully raised
		if (locked == false) {
			if (transform.position.y < 22) {
				// Animate the door raising up
				transform.Translate (0, 10 * Time.deltaTime, 0, Space.World);
			}
		}
    }

	public void Unlock()
	{
		// You'll need to set "locked" to true here
		// Carl ->  this method will be called once key is found
		// Carl ->  therefore update locked to false
		locked = false;
	}
}
