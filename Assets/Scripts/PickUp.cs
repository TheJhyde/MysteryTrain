 using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	//Lets you pick up an item when you click on it

	public bool pickedUp;
	CursorHandler cursor;
	GameObject objectsBox;
	public bool debugText;

	// Use this for initialization
	void Start () {
		pickedUp = false;
		cursor = GameObject.Find("Cursor").GetComponent<CursorHandler>();
		//Debug.Log(cursor);
		objectsBox = GameObject.Find ("InteractionObjects");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(name + " is picked up: " + pickedUp);
		//if you're currently being carried, drop the object when clicked
		if(pickedUp && Input.GetMouseButtonDown(0)){
			drop ();
		}
	}

	void onClick(){
		if(!pickedUp){
			if(debugText){ Debug.Log(name + " received a click."); }
			//turn off the hand, because you're holding something
			cursor.switchCursor(5);
			cursor.isHolding = true;
			cursor.heldObject = transform;
			//Debug.Log ("Holding " + transform.name);
			//move the object up to the cursor layer
			transform.position = new Vector3(transform.position.x, transform.position.y, -3);
			//put it in the cursor object
			transform.parent = cursor.transform;
			//turn off the collider and the rigid body
			GetComponent<Collider2D>().enabled = false;
			GetComponent<Rigidbody2D>().isKinematic = true;
			//I think things are being picked up and then immediately dropped again, so here's a really ugly fix
			Invoke ("switchPickedState", 0.01f);
		}
	}

	void switchPickedState(){
		pickedUp = !pickedUp;
	}

	public void drop(){
		if(debugText){
			Debug.Log (name + " should be being dropped now");
		}
		GetComponent<Collider2D>().enabled = true;
		//I would like it if you couldn't drop an object if it currently overlaps with anything
		GetComponent<Rigidbody2D>().isKinematic = false;
		transform.parent = objectsBox.transform;
		transform.position = new Vector3(transform.position.x, transform.position.y, -2);
		//turn the hand back on
		cursor.switchCursor(1);
		cursor.isHolding = false;
		cursor.heldObject = cursor.transform;
		Invoke ("switchPickedState", 0.01f);
	}
}
