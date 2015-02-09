using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	//Restarts the game

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onClick(){
		Application.LoadLevel("Train1");
	}
}
