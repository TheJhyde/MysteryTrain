using UnityEngine;
using System.Collections;

public class BackgroundAdd : MonoBehaviour {

	//Randomly generates background tiles and places them in front of the train.

	//the rightmost background tile. Put the first one in here
	GameObject rightBackground;
	public SpriteRenderer rightBackSr;
	public Transform backgroundParent;
	public GameObject[] backgrounds;

	public float speed;

	// Use this for initialization
	void Start () {
		backgroundParent = GameObject.Find ("BackgroundHolder").transform;
		//adds three backgrounds tiles at the start
		for(int i = 0; i < 3; i++){
			GameObject newBackground = (GameObject)Instantiate(backgrounds[Random.Range(0, backgrounds.Length)]);
			newBackground.transform.parent = backgroundParent;
			newBackground.transform.position = new Vector3(i*7-7, 0, 0);
			newBackground.GetComponent<BackgroundMover>().speed = speed;
		}
		//adds the final, rightmost background tile
		rightBackground = (GameObject)Instantiate(backgrounds[Random.Range(0, backgrounds.Length)]);
		rightBackground.transform.parent = backgroundParent;
		rightBackground.transform.position = new Vector3(14, 0, 0);
		rightBackground.GetComponent<BackgroundMover>().speed = speed;
		rightBackSr = rightBackground.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(rightBackSr.isVisible){
			GameObject newBackground = (GameObject)Instantiate(backgrounds[Random.Range(0, backgrounds.Length)]);
			newBackground.transform.parent = backgroundParent;
			SpriteRenderer newSr = newBackground.GetComponent<SpriteRenderer>();
			//there are small gaps appearing in this, don't know why
			//appears to be related to the speed, since the gap increases when I increase the speed

			newBackground.transform.position = new Vector3(rightBackSr.bounds.max.x + newSr.bounds.extents.x, 0, 0);
			newBackground.GetComponent<BackgroundMover>().speed = speed;

			rightBackSr = newBackground.GetComponent<SpriteRenderer>();
			rightBackground = newBackground;
		}
	}
}
