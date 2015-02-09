using UnityEngine;
using System.Collections;

public class Drifter : MonoBehaviour {
	//For zero gravity objects - causes them to drift around in space at a random speed and direction

	Rigidbody2D body;
	PickUp p;
	bool beingHeld = false;
	public float speed = 20;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
		p = GetComponent<PickUp>();
		resetDrift();
	}
	
	// Update is called once per frame
	void Update () {
		if(p.pickedUp && !beingHeld){
			beingHeld = true;
		}

		if(!p.pickedUp && beingHeld){
			resetDrift();
			beingHeld = false;
		}
	}

	public void resetDrift(){
		body.AddForce(new Vector2(Random.Range(-speed, speed), Random.Range(-speed, speed)));
		body.angularVelocity = Random.Range(-speed, speed);
	}
}
