using UnityEngine;
using System.Collections;

public class Unlock : MonoBehaviour {
	//Handles the lock, both before unlocked and after it's been unlocked

	int shake = 0;
	float rotate = 0;
	public bool unlocked = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(shake == 1 || shake == 3){
			rotate += Time.deltaTime * 30;
			if(rotate >= 10 && shake == 1){
				shake = 2;
			}
			if(rotate >= 0 && shake == 3){
				shake = 0;
				rotate = 0;
			}
		}else if(shake == 2){
			rotate -= Time.deltaTime*30;
			if(rotate <= -10){
				shake = 3;
			}
		}
		transform.eulerAngles = new Vector3(0, 0, rotate);

	}

	void onClick(Transform holding){
		if(holding.name == "Key"){
			GetComponent<Rigidbody2D>().isKinematic = false;
			Invoke("addPickUp", 0.05f);
			unlocked = true;
		}else if (!unlocked){
			shake = 1;
		}
	}

	void addPickUp(){
		gameObject.AddComponent<PickUp>();
	}
}
