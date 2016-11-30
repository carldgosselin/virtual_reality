using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoofPrefab;
	public GameObject door;

	void Update()
	{
		//Bonus: Key Animation
		// Carl -> Key is animated using the Animation console
	}

	public void OnKeyClicked()
	{

		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
        
        // Call the KeyCollected() method on the Door
		door.GetComponent<Door>().keyCollected();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);

    }

}
