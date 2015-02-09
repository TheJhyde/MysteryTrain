using UnityEngine;
using System.Collections;

//this is a method to handle when an object has multiple colliders
public class CollidersManager : MonoBehaviour {

	PickUp p;
	bool wasDropped = true;
	Collider2D[] colliders;

	// Use this for initialization
	void Start () {
		p = GetComponent<PickUp>();
		colliders = GetComponents<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(p.pickedUp && wasDropped){
			for(int i = 0; i < colliders.Length; i++){
				colliders[i].enabled = false;
			}
			wasDropped = false;
		}

		if(!p.pickedUp && !wasDropped){
			for(int i = 0; i < colliders.Length; i++){
				colliders[i].enabled = true;
			}
			wasDropped = true;
		}
	}
}
