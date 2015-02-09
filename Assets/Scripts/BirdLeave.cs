using UnityEngine;
using System.Collections;

public class BirdLeave : MonoBehaviour {
	//Makes the bird fly to the egg when clicked on.

	public GameObject bird;
	bool hatched = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void onClick(){
		if(!hatched){
			bird.GetComponent<FlyToEgg>().onClick();
			hatched = true;
		}
	}
}
