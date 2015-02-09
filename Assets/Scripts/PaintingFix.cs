using UnityEngine;
using System.Collections;

public class PaintingFix : MonoBehaviour {
	//fixes the way the painting is hung when you click on it.

	float t;
	Vector3 start;
	Vector3 end;

	// Use this for initialization
	void Start () {
		t = 1;
		start = transform.localEulerAngles;
		end = transform.localEulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime*2;
		transform.localEulerAngles = Vector3.Lerp(start, end, t);
	}

	void onClick(){
		t = 0;
		start = transform.localEulerAngles;
		if(transform.localEulerAngles == Vector3.zero){
			end = new Vector3(0, 0, 10);
		}else{
			end = Vector3.zero;
		}

	}
}
