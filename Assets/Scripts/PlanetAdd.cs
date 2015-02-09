using UnityEngine;
using System.Collections;

public class PlanetAdd : MonoBehaviour {
	//lets you add pieces of the shattered planet

	AddToPlanet ap;
	AudioSource soundEffect;

	// Use this for initialization
	void Start () {
		ap = GameObject.Find("Planet3").GetComponent<AddToPlanet>();
		soundEffect = GameObject.Find ("Planet3").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		//Debug.Log ("Something entered!");
		if(other.name == gameObject.name){
			GetComponent<SpriteRenderer>().enabled = true;
			GetComponent<PolygonCollider2D>().isTrigger = false;
			GetComponent<PlayPlanet3>().enabled = true;
			gameObject.layer = 10;
			ap.completion++;
			soundEffect.Play ();
			Destroy(other.gameObject);
		}
	}
}
