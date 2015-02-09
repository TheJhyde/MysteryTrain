using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	//Finishes the game

	bool slowDown = false;
	BackgroundAdd adder;
	Transform holder;
	public GameObject finalBackground;
	GameObject restartButton;
	GameObject quitButton;
	AudioSource shutDown;

	// Use this for initialization
	void Start () {
		adder = GameObject.Find("GameManager").GetComponent<BackgroundAdd>();
		holder = GameObject.Find ("BackgroundHolder").transform;

		restartButton = GameObject.Find ("RestartButton");
		restartButton.SetActive(false);
		quitButton = GameObject.Find ("QuitButton");
		quitButton.SetActive(false);

		shutDown = GetComponent<AudioSource>();

	}

	void Update(){
		if(slowDown){
			if(adder.speed <= 10 && adder.speed >= 9){
				adder.backgrounds =  new GameObject[1];
				adder.backgrounds[0] = finalBackground;
			}else if(adder.speed <= 0){
				slowDown = false;
				Invoke("activateButtons", 2);
			}

			adder.speed -= Time.deltaTime * 2;
			for(int i = 0; i < holder.childCount; i++){
				holder.GetChild(i).gameObject.GetComponent<BackgroundMover>().speed -= Time.deltaTime * 2;
			}
		}

		if(adder.speed <= 0){
			adder.speed = 0;
		}
	}

	void onClick(){
		if(!slowDown){
			shutDown.Play();
			slowDown = true;
			transform.position = new Vector3(-0.524245f, -0.3084037f, -1.9f);
		}
	}

	void activateButtons(){
		restartButton.SetActive(true);
		quitButton.SetActive(true);
	}
}
