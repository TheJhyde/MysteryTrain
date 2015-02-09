using UnityEngine;
using System.Collections;

public class GoToBigPlanet : MonoBehaviour {
	//moves the smaller planet towards the big planet

	public bool start = false;
	Transform bigPlanet;
	float lerpTime;
	Vector3 startPos;
	PlanetRotate p;

	// Use this for initialization
	void Start () {
		bigPlanet = GameObject.Find("Planet3").transform;
		startPos = transform.position;
		lerpTime = 0;

		p = GetComponent<PlanetRotate>();
		p.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(start){
			lerpTime += Time.deltaTime/3;
			transform.position = Vector3.Lerp(startPos, bigPlanet.position + new Vector3(0, p.radius, 0), lerpTime);
		}

		if(lerpTime >= 1){
			p.enabled = true;
			start = false;
		}
	}
}
