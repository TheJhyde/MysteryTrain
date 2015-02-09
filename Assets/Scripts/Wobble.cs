using UnityEngine;
using System.Collections;

public class Wobble : MonoBehaviour {
	//Causes the attached object to wobble slightly
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onClick(){
		rigidbody2D.AddForce(new Vector2(120, 0));
	}
}
