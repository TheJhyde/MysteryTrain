using UnityEngine;
using System.Collections;

public class KeyDrop : MonoBehaviour {
	//Forces the cursor to drop the key.

	//bool growl = false;
//	public Transform mouthTop;
//	public Transform mouthBottom;
	PickUp keyPickUp;
	bool wasDropped = true;
//	public bool openingMouth = false;
	PantherClick pc;

	// Use this for initialization
	void Start () {
		keyPickUp = GameObject.Find("Key").GetComponent<PickUp>();
		pc = GetComponent<PantherClick>();
	}
	
	// Update is called once per frame
	void Update () {
		if(keyPickUp.pickedUp && !pc.fed && wasDropped){
			pc.meow.Play();
			pc.openingMouth = true;
			Invoke ("dropKey", 0.1f);
			wasDropped = false;
			//keyPickUp.drop();
		}
		if(!keyPickUp.pickedUp){
			wasDropped = true;
		}
//		if(openingMouth){
//			mouthTop.localPosition += new Vector3(0, Time.deltaTime, 0);
//			mouthBottom.localPosition -= new Vector3(0, Time.deltaTime, 0);
//			if(mouthTop.localPosition.y >= 0.5){
//				mouthTop.localPosition = new Vector3(-0.74f, 0.5f, 0);
//				mouthBottom.localPosition = new Vector3(-0.74f, -0.5f, 0);
//				openingMouth = false;
//			}
//		}else{
//			if(mouthTop.localPosition.y > 0.25){
//				mouthTop.localPosition -= new Vector3(0, Time.deltaTime, 0);
//				mouthBottom.localPosition += new Vector3(0, Time.deltaTime, 0);
//			}else if(mouthTop.localPosition.y < 0.25){
//				mouthTop.localPosition = new Vector3(-0.74f, 0.25f, 0);
//				mouthBottom.localPosition = new Vector3(-0.74f, -0.25f, 0);
//			}
//		}
	}

	void dropKey(){
		keyPickUp.drop();
	}
}
