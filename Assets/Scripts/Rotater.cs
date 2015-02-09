using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {
	//rotates an object

	float rotate;

	// Use this for initialization
	void Start () {
		rotate = 0;
	}
	
	// Update is called once per frame
	void Update () {
		rotate += Time.deltaTime*60;
		transform.localEulerAngles = new Vector3(0, 0, rotate);
	}
}
