using UnityEngine;
using System.Collections;

public class SendToBeneath : MonoBehaviour {
	//sends a message to the box underneath this box

	public GameObject nextBox;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onClick(){
		//Debug.Log ("I also ran when you clicked me");
		nextBox.SendMessage("unHide");
	}
}
