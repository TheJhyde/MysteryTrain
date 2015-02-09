using UnityEngine;
using System.Collections;

public class PlanetRotate : MonoBehaviour {
	//Causes a planet to rotate around a given point

	Transform center;
	public float radius = 1;
	float angle = 0;
	bool direction;
	public string orbitPlanet;
	public float speed = 1;


	// Use this for initialization
	void Start () {
		center = GameObject.Find(orbitPlanet).transform;
		direction = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(direction){
			angle += Time.deltaTime * speed;
		}else{
			angle -= Time.deltaTime * speed;
		}
		transform.position = center.position + new Vector3(Mathf.Sin(angle)*radius, Mathf.Cos(angle) * radius, 0);
	}

	void onClick(){
		direction = !direction;
	}
}
