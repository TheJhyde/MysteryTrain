using UnityEngine;
using System.Collections;

public class BackgroundMover : MonoBehaviour {

	//Moves background train tiles so the train looks like it's moving. Then deletes them when they're not needed.
	public float speed;
	SpriteRenderer sr;
	public bool visible;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
		visible = sr.isVisible;

		if(!sr.isVisible && transform.position.x < -10){
			Destroy(gameObject);
		}
	}
}
