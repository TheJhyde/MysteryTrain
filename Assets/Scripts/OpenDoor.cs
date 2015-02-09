using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
	//Lets the door swing open. Causes it to fail to open if anything is in the way.

	// 1 = opening
	// 0 = stay
	// -1 = closing
	int opening;
	bool closed;
	float angle;

	public string nextScene;

	// Use this for initialization
	void Start () {
		opening = 0;
		angle = 6;
		closed = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(opening == 1){
			if(angle < 90){
				angle += 90 * Time.deltaTime;
				transform.localScale = new Vector3(Mathf.Sin(angle*Mathf.Deg2Rad), 1, 1);
			}else{
				transform.localScale = new Vector3(1, 1, 1);
				opening = 0;
				angle = 90;
				closed = false;
				Invoke ("loadScene", 1);
			}
		} else if(opening == -1){
			if(angle > 6){
				angle -= 90* Time.deltaTime;
				transform.localScale = new Vector3(Mathf.Sin(angle*Mathf.Deg2Rad), 1, 1);
			}else{
				transform.localScale = new Vector3(0.1f, 1, 1);
				opening = 0;
				angle = 6;
				closed = true;
			}
		}
	}

	void onClick(){
		if(closed){
			opening = 1;
		}else{
			loadScene();
		}
	}
	 
	void OnTriggerEnter2D(Collider2D other){
		//Debug.Log("You collided");
		opening = -1;
	}

	void loadScene(){
		Application.LoadLevel(nextScene);
	}

//	void OnTriggerStay2D(Collider2D other){
//		if(other.gameObject.CompareTag("Cursor")){
//			if(Input.GetMouseButtonDown(0)){
//				if(closed){
//					opening = 1;
//				}else{
//					Application.LoadLevel(nextScene);
//				}
//			}
//		}
//	}
}
