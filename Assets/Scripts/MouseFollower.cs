using UnityEngine;
using System.Collections;

public class MouseFollower : MonoBehaviour {
	//Lets something follow the mouse around

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 7);
	}
}
