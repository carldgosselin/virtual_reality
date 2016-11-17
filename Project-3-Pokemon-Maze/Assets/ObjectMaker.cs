using UnityEngine;
using System.Collections;

public class ObjectMaker : MonoBehaviour {

	public GameObject coinOne;
	public GameObject masterKey;

	// Use this for initialization
	void Start () {

		//Object.Instantiate(coinOne, new Vector3 (2, 2, 2), Quaternion.identity);
		//Object.Instantiate(masterKey, new Vector3 (8, 4, -8), Quaternion.identity);
		//Object.Instantiate(masterKey, new Vector3 (0, 5 + Mathf.Sin (Time.time * 5.0f), 0), Quaternion.identity);
		//for (int i = 0; i < 10; i++) {
			//Object.Instantiate(objectToCreate, new Vector3 (i+4, 2, 2), Quaternion.identity);
			//Object.Instantiate(objectToCreate, new Vector3 (2, 2, i+3), Quaternion.identity);
		//}
	}
	
	// Update is called once per frame
	void Update () {
		//masterKey.transform.position = new Vector3 (0, 5 + Mathf.Sin (Time.time * 5.0f), 0);
	}
}
