using UnityEngine;
using System.Collections;

public class PantherClick : MonoBehaviour {
	//Handles everything that happens when you click on the panther

	public bool openingMouth = false;
	public bool fed = false;
	public Transform mouthTop;
	public Transform mouthBottom;
	public AudioSource meow;

	// Use this for initialization
	void Start () {
		meow = GetComponent<AudioSource>();
	}	
	
	// Update is called once per frame
	void Update () {
		if(openingMouth){
			mouthTop.localPosition += new Vector3(0, Time.deltaTime, 0);
			mouthBottom.localPosition -= new Vector3(0, Time.deltaTime, 0);
			if(mouthTop.localPosition.y >= 0.5){
				mouthTop.localPosition = new Vector3(-0.74f, 0.5f, 0);
				mouthBottom.localPosition = new Vector3(-0.74f, -0.5f, 0);
				openingMouth = false;
			}
		}else{
			if(mouthTop.localPosition.y > 0.25){
				mouthTop.localPosition -= new Vector3(0, Time.deltaTime, 0);
				mouthBottom.localPosition += new Vector3(0, Time.deltaTime, 0);
			}else if(mouthTop.localPosition.y < 0.25){
				mouthTop.localPosition = new Vector3(-0.74f, 0.25f, 0);
				mouthBottom.localPosition = new Vector3(-0.74f, -0.25f, 0);
			}
		}

	}

	void onClick(Transform holding){
		if(holding.name == "Fish" && !fed){
			mouthTop.localPosition = new Vector3(-0.74f, 0.5f, 0);
			mouthBottom.localPosition = new Vector3(-0.74f, -0.5f, 0);
//			holding.parent = transform;
//			holding.localPosition = new Vector3(-0.74f, 0, 0);
//			holding.gameObject.GetComponent<PickUp>().enabled = false;
//			holding.gameObject.GetComponent<Collider2D>().enabled = false;
//			holding.gameObject.rigidbody2D.isKinematic = true;
			Destroy (holding.gameObject);

			fed = true;
		}else if(!fed){
			openingMouth = true;
		}
		meow.Play();
	}
}
