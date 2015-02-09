using UnityEngine;
using System.Collections;

public class AquariumFloat : MonoBehaviour {

	// Makes anything put in the aquarium float and not float when removed.
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collide){
		if(collide.gameObject.name == "Fish"){
			collide.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
			collide.gameObject.rigidbody2D.velocity = Vector2.zero;
			collide.gameObject.GetComponent<FishHandler>().inTank = true;
		}
	}

	void OnTriggerExit2D(Collider2D collide){
		if(collide.gameObject.name == "Fish"){
			collide.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
		}
	}
}
