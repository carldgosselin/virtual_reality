﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// AVPro functionality
using RenderHeads.Media.AVProVideo;

public class MyControlPanel : MonoBehaviour {

	// Variables
	public MediaPlayer _mediaPlayer;
	public GameObject introUI, controlsUI, creditsUI, goToCastleUI, backButton;
	public GameObject crowdSound, insideCastle;

	float current_time;

	// Use this for initialization
	void Start () {

		controlsUI.SetActive (false);
		creditsUI.SetActive (false);
		goToCastleUI.SetActive (false);
		introUI.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
		current_time = _mediaPlayer.Control.GetCurrentTimeMs();

		// Hide "go to castle" button when already inside castle
		if (current_time >= 35000) {

			goToCastleUI.SetActive (false);
		}

		// Show Credit screen at end of video
		if (current_time >= 85000) {

			creditsUI.SetActive (true);
			controlsUI.SetActive (false);
			backButton.SetActive (false);
		}
	}
		
	// Play button
	public void OnPlayButton()
	{
			_mediaPlayer.Control.Play();
			crowdSound.GetComponent<GvrAudioSource> ().Play();
	}

	// Pause button
	public void OnPauseButton()
	{
		_mediaPlayer.Control.Pause();
		crowdSound.GetComponent<GvrAudioSource> ().Pause();
		insideCastle.GetComponent<GvrAudioSource> ().Pause();
	}

	// Restart button
	public void OnRestartButton()
	{
		_mediaPlayer.Control.Stop();
		_mediaPlayer.Control.Rewind();
		goToCastleUI.SetActive (true);
		crowdSound.GetComponent<GvrAudioSource> ().Stop();
		insideCastle.GetComponent<GvrAudioSource> ().Stop();
	}

	// "Let's Go" button
	public void OnIntroButton()
	{

		ParticleSystem ps = GetComponent<ParticleSystem>();
		ps.Play();

		introUI.SetActive (false);
		controlsUI.SetActive (true);
		goToCastleUI.SetActive (true);
	}

	// View credits button
	public void OnViewCreditsButton()
	{
		creditsUI.SetActive (true);
		controlsUI.SetActive (false);
	}

	// Back button on Credits panel
	public void OnBackButton()
	{
		creditsUI.SetActive (false);
		controlsUI.SetActive (true);
	}

	// Go to castle button
	public void OnGoToCastleButton()
	{
		crowdSound.GetComponent<GvrAudioSource> ().Stop();

		// Variable for video time showing desired scene (castle close-up view) 
		float timeslot_1 = 35000;

		// Hide/show buttons after button click
		goToCastleUI.SetActive (false);

		// Fast-forward movie to specific time
		_mediaPlayer.Control.Seek (timeslot_1);

		_mediaPlayer.Control.Play();
		insideCastle.GetComponent<GvrAudioSource> ().Play();
	}
}
