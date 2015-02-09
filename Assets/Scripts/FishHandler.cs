using UnityEngine;
using System.Collections;

public class FishHandler : MonoBehaviour {
	//Generates fish and handles them while they're swimming around in the aquarium

	Rigidbody2D rb;
	public bool goRight = true;
	public bool inTank = true;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer>().color = randomColor();
	}
	
	// Update is called once per frame
	void Update () {
		if(inTank){
			if(goRight){
				transform.localScale = new Vector3(1, 1, 1);
				transform.position += new Vector3(Time.deltaTime, 0, 0);
			}else{
				transform.localScale = new Vector3(-1, 1, 1);
				transform.position -= new Vector3(Time.deltaTime, 0, 0);
			}
		}
	}

	Color randomColor(){
		Color[] colors = new Color[7] {Color.red, Color.black, Color.white, Color.green, Color.cyan, Color.magenta, Color.yellow};
		return colors[Random.Range(0, colors.Length)];
	}

	void OnCollisionEnter2D(Collision2D collide){
		if(inTank){
			goRight = !goRight;
		}
	}

	void onClick(){
		inTank = false;
		rigidbody2D.gravityScale = 1;
	}
}
