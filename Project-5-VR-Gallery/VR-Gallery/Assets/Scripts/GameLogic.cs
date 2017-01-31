using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour { 

	public GameObject player;
	public GameObject startPoint, booth1, booth2, booth3, booth4, booth5, booth6;
	public GameObject booth1Sound, booth2Sound, booth3Sound, booth4Sound, booth5Sound, booth6Sound;
	public GameObject Booth1Nav, Booth2Nav, Booth3Nav, Booth4Nav, Booth5Nav, Booth6Nav;

	// Use this for initialization
	void Start () {
		hideControls (); 
	}

	// Update is called once per frame
	void Update () {

	}

	public void stopAudio () {

		booth1Sound.GetComponent<GvrAudioSource> ().Stop();
		booth2Sound.GetComponent<GvrAudioSource> ().Stop();
		booth3Sound.GetComponent<GvrAudioSource> ().Stop();
		booth4Sound.GetComponent<GvrAudioSource> ().Stop();
		booth5Sound.GetComponent<GvrAudioSource> ().Stop();
		booth6Sound.GetComponent<GvrAudioSource> ().Stop();

	}

	public void hideControls () {

		Booth1Nav.SetActive (false);
		Booth2Nav.SetActive (false);
		Booth3Nav.SetActive (false);
		Booth4Nav.SetActive (false);
		Booth5Nav.SetActive (false);
		Booth6Nav.SetActive (false);
	}

	// Booth selection...
	public void goToBooth1 () {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", booth1.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
		stopAudio ();
		hideControls ();
		Booth1Nav.SetActive (true);
		booth1Sound.GetComponent<GvrAudioSource> ().Play ();

	}

	public void goToBooth2 () {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", booth2.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
		stopAudio ();
		hideControls ();
		Booth2Nav.SetActive (true);
		booth2Sound.GetComponent<GvrAudioSource> ().Play ();

	}
	public void goToBooth3 () {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", booth3.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
		stopAudio ();
		hideControls ();
		Booth3Nav.SetActive (true);
		booth3Sound.GetComponent<GvrAudioSource> ().Play ();
	}
	public void goToBooth4 () {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", booth4.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
		stopAudio ();
		hideControls ();
		Booth4Nav.SetActive (true);
		booth4Sound.GetComponent<GvrAudioSource> ().Play ();
	}
	public void goToBooth5 () {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", booth5.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
		stopAudio ();
		hideControls ();
		Booth5Nav.SetActive (true);
		booth5Sound.GetComponent<GvrAudioSource> ().Play ();
	}
	public void goToBooth6 () {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", booth6.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
		stopAudio ();
		hideControls ();
		Booth6Nav.SetActive (true);
		booth6Sound.GetComponent<GvrAudioSource> ().Play ();
	}


	public void goToStart () {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", startPoint.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
		stopAudio ();
		hideControls ();
	}
}