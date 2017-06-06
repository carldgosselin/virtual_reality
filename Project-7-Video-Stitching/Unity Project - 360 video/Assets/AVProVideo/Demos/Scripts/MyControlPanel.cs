using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Carl - AVPro functionality
using RenderHeads.Media.AVProVideo;

public class MyControlPanel : MonoBehaviour {

	// Carl - variable to recognize the MediaPlayer to control
	public MediaPlayer _mediaPlayer;

	// Carl - show hide panels
	public GameObject introUI, controlsUI;

	// Use this for initialization
	void Start () {

		controlsUI.SetActive (false);
		introUI.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	}
		
	// Carl - add code for play button
	public void OnPlayButton()
	{
			_mediaPlayer.Control.Play();
	}

	// Carl - add code for Pause button
	public void OnPauseButton()
	{
		_mediaPlayer.Control.Pause();
	}

	public void OnRestartButton()
	{
		_mediaPlayer.Control.Rewind();
	}

	public void OnIntroButton()
	{
		introUI.SetActive (false);
		controlsUI.SetActive (true);
	}
				
}
