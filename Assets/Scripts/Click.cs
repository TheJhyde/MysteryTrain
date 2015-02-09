using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
	//Handles interacting with objects
	private LayerMask mask = 1 << 10;

	CursorHandler cursor;

	// Use this for initialization
	void Start () {
		cursor = GameObject.Find("Cursor").GetComponent<CursorHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		//go find an object on the objects layer
		RaycastHit2D castHit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.zero, 0f, mask);
		//if you find one
		if(castHit.transform != null){
			cursor.switchCursor(2);
			if(Input.GetMouseButtonDown(0)){ //if we are clicking
				//the object we clicked
				GameObject hit = castHit.transform.gameObject;
				if(hit.transform.position.z != 0){ //if it's not on the cursor layer
					//tell it to do the thing it does when it's clicked on
					hit.SendMessage("onClick", cursor.heldObject, SendMessageOptions.DontRequireReceiver);
				}
			}
		}else if(!cursor.isHolding){
			cursor.switchCursor(1);
		}else{
			cursor.switchCursor(5);
		}
	}

	Transform getActiveChild(){
		for(int i = 0; i < transform.childCount; i++){
			if(!transform.GetChild(i).name.StartsWith("Cursor")){
				return transform.GetChild(i);
			}
		}
		return transform.GetChild(1);
	}

}
