using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {


	public GameObject Camera_Viewer;
	public GameObject GoogleRoom;
	public GameObject OnStage;
	public GameObject spinning_cube;
	public GameObject LetsDoThis1;
	public GameObject OuterSpace;
	public GameObject HeartBeat;
	public GameObject CrowdCheerLow;
	public GameObject CrowdCheerLoud;
	public GameObject Jump;
	public GameObject Sputnik;
	public GameObject Earth;
	public GameObject Particles;

	// Use this for initialization
	void Start () {

		LetsDoThis1.SetActive (false);
		HeartBeat.GetComponentInChildren<GvrAudioSource> ().Play();
		CrowdCheerLow.GetComponentInChildren<GvrAudioSource> ().Play();
	
	}

	// Update is called once per frame
	void Update () {

		spinning_cube.transform.Rotate (Vector3.up, 100f * Time.deltaTime);
		Earth.transform.Rotate (Vector3.up, 50f * Time.deltaTime);
		
	}

	public void GoToStage () {

		spinning_cube.SetActive (true);
		LetsDoThis1.SetActive (false);
		HeartBeat.GetComponentInChildren<GvrAudioSource> ().Stop();
		CrowdCheerLow.GetComponentInChildren<GvrAudioSource> ().Stop();
		CrowdCheerLoud.GetComponentInChildren<GvrAudioSource> ().Play();

		iTween.MoveTo (Camera_Viewer, 
			iTween.Hash (
				"position", OnStage.transform.position, 
				"time", 3, 
				"easetype", "linear"
			)
		);
	}

	public void GoToCube () {

		ParticleSystem ps = Particles.GetComponent<ParticleSystem>();
		ps.Play();


		spinning_cube.SetActive (false);
		LetsDoThis1.SetActive (true);

		iTween.MoveTo (Camera_Viewer, 
			iTween.Hash (
				"position", spinning_cube.transform.position, 
				"time", 2, 
				"easetype", "linear"
			)
		);

	}

	public void GoToOuterSpace () {

		CrowdCheerLoud.GetComponentInChildren<GvrAudioSource> ().Stop();
		Jump.GetComponentInChildren<GvrAudioSource> ().Play();
		Sputnik.GetComponentInChildren<GvrAudioSource> ().Play();

		iTween.MoveTo (Camera_Viewer, 
			iTween.Hash (
				"position", OuterSpace.transform.position, 
				"time", 2, 
				"easetype", "linear"
			)
		);

	}

	public void BackToEarth () {

		iTween.MoveTo (Camera_Viewer, 
			iTween.Hash (
				"position", spinning_cube.transform.position, 
				"time", 2, 
				"easetype", "linear"
			)
		);

		CrowdCheerLoud.GetComponentInChildren<GvrAudioSource> ().Play();
	}

	public void GoToGoogleRoom () {

		iTween.MoveTo (Camera_Viewer, 
			iTween.Hash (
				"position", GoogleRoom.transform.position, 
				"time", 2, 
				"easetype", "linear"
			)
		);

		HeartBeat.GetComponentInChildren<GvrAudioSource> ().Play();
		CrowdCheerLow.GetComponentInChildren<GvrAudioSource> ().Play();
		CrowdCheerLoud.GetComponentInChildren<GvrAudioSource> ().Stop();

	}
}
