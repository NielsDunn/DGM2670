﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class ClickSound : MonoBehaviour {

	public AudioClip sfxClick;

	private Button button {get {return GetComponent<Button>(); }}
	private AudioSource source {get {return GetComponent<AudioSource>();}}

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource>();
		source.clip = sfxClick;
		source.playOnAwake = false;

		button.onClick.AddListener(()=> PlaySound());
	}
	
	void PlaySound()
	{
	source.PlayOneShot(sfxClick);
	}
}