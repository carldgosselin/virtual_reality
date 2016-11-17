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
		// First test
		Debug.Log ("Inside onKeyClicked method");

		// Instatiate the KeyPoof Prefab where this key is located
		//Object.Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(14,3,16));
		//Object.Instantiate(KeyPoofPrefab, new Vector3 (14, 3, 16), Quaternion.identity);
		Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
        
		// Make sure the poof animates vertically

        // Call the Unlock() method on the Door
		door.GetComponent<Door>().Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);

    }

}
