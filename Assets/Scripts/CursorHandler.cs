using UnityEngine;
using System.Collections;

public class CursorHandler : MonoBehaviour {
	//Makes sure that the cursor is displayed correctly for the kind of interaction it's currently doing

	/* 
	 * 1 - Basic Hand
	   2 - Pointer
	   3 - Arrow Left
	   4 - Arrow Right
	   5 - No Cursor
	*/
	GameObject hand;
	GameObject pointer;
	GameObject arrow;

	public bool isHolding = false;

	public Transform heldObject;

	// Use this for initialization
	void Start () {
		hand = GameObject.Find ("CursorHand");
		pointer = GameObject.Find("CursorPointer");
		arrow = GameObject.Find ("CursorArrow");

		switchCursor(1);
		heldObject = transform;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void switchCursor(int value){
		//Debug.Log("Switching the cursor to " + value);
		switch(value){
		case 5:
			hand.SetActive(false);
			pointer.SetActive(false);
			arrow.SetActive(false);
			break;
			
		case 1:
			hand.SetActive(true);
			pointer.SetActive(false);
			arrow.SetActive(false);
			break;
			
		case 2:
			hand.SetActive(false);
			pointer.SetActive(true);
			arrow.SetActive(false);
			break;
		
		case 3:
			//Debug.Log ("going right");
			hand.SetActive(false);
			pointer.SetActive(false);
			arrow.SetActive(true);
			arrow.transform.localScale= new Vector3(-1, 1, 1);
			break;

		case 4:
			//Debug.Log ("going left");
			hand.SetActive(false);
			pointer.SetActive(false);
			arrow.SetActive(true);
			arrow.transform.localScale = new Vector3(1, 1, 1);
			break;

		default:
			Debug.Log ("Somebody tried to change the cursor to " +value+ " and that's wrong");
			break;
		}
	}
}
