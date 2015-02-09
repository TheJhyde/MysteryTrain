using UnityEngine;
using System.Collections;

public class PlayPlanet3 : MonoBehaviour {
	//plays Planet 3's sound

	PlaySound playSound;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		playSound = GameObject.Find ("Planet3").GetComponent<PlaySound>();
		sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void onClick(){
		if(sr.enabled){
			playSound.onClick();
		}
	}
}
