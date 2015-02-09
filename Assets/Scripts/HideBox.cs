using UnityEngine;
using System.Collections;

public class HideBox : MonoBehaviour {
	//Hides a box behind the other boxes, until it is revealed.

	//SpriteRenderer sr;
	bool seen;

	// Use this for initialization
	void Start () {
		//sr = GetComponent<SpriteRenderer>();
		GetComponent<Rigidbody2D>().isKinematic = true;
		GetComponent<BoxCollider2D>().enabled = false;
		seen = false;
	}
	
	// Update is called once per frame
	void Update () {
//		if(sr.isVisible && !seen){
//			transform.position = new Vector3(transform.position.x, transform.position.y, -2);
//			Debug.Log("I have just been seen");
//			GetComponent<Rigidbody2D>().isKinematic = false;
//			GetComponent<BoxCollider2D>().enabled = true;
//			seen = true;
//		}
	}

	void unHide(){
		if(!seen){
			transform.position = new Vector3(transform.position.x, transform.position.y, -2);
			//Debug.Log("I have just been seen");
			GetComponent<Rigidbody2D>().isKinematic = false;
			GetComponent<BoxCollider2D>().enabled = true;
			seen = true;
		}
	}
}
