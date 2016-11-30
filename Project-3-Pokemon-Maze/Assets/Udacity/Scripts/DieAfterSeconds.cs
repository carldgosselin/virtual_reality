using UnityEngine;
using System.Collections;

public class DieAfterSeconds : MonoBehaviour {
    IEnumerator Start () {
        
		//Changed WaitForSeconds from 2.0f to 3.0
		yield return new WaitForSeconds(3.0f);
        
		Destroy(gameObject);
	}
}
