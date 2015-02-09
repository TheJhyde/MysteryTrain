using UnityEngine;
using System.Collections;


public class AddToPlanet : MonoBehaviour {

	//Keeps track of how many of the planet fragments have been added to the big planet
	//And tells the small planet to travel over there when it's done
	public int completion;
	GoToBigPlanet go;

	void Start () {
		go = GameObject.Find ("Planet1").GetComponent<GoToBigPlanet>();
	}
	
	void Update () {
		if(completion == transform.childCount){
			go.start = true;
			completion++;
		}

		if(Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
