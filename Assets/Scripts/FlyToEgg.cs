using UnityEngine;
using System.Collections;

public class FlyToEgg : MonoBehaviour {

	public GameObject eggTop;
	public GameObject eggBottom;
	public GameObject egg;

	bool flying = false;
	bool direction = false;
	float time = 0;
	Vector3 start;
	Vector3 end;

	Unlock cageLock;

	// Use this for initialization
	void Start () {
		eggTop.SetActive(false);
		eggBottom.SetActive(false);

		start = transform.position;
		SpriteRenderer sr = egg.GetComponent<SpriteRenderer>();
		end = egg.transform.position + new Vector3(0, sr.bounds.extents.y+0.2f, 0);
		cageLock = GameObject.Find ("Lock").GetComponent<Unlock>();
	}
	
	// Update is called once per frame
	void Update () {
		if(flying){
			Debug.Log("Flying to egg!");
			if(direction){
				time += Time.deltaTime / 4;
			}else{
				time -= Time.deltaTime / 4;
			}
			transform.position = Vector3.Lerp(start, end, time);
		}
		if(time >= 1){
			egg.SetActive(false);
			eggTop.SetActive(true);
			eggBottom.SetActive(true);
		}
	}

	public void onClick(){
		if(cageLock.unlocked){
			flying = true;
			direction = !direction;
			if(time > 1){
				time = 1;
			} else if (time < 0){
				time = 0;
			}
		}
	}
//	public void returnToEgg(){
//		flying = true;
//		direction = false;
//	}
}
