using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
	//plays the given sound when the object is clicked on

	AudioSource sound;

	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource>();
	}

	public void onClick(){
		sound.Play();
	}
}
