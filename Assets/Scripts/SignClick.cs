using UnityEngine;
using System.Collections;

public class SignClick : MonoBehaviour {
	//handles when you click on the door

	GameObject door;

	void Start () {
		door = GameObject.Find("Door");
	}

	void onClick(){
		door.SendMessage("onClick");
	}
}
