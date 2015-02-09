using UnityEngine;
using System.Collections;

public class FadeToBlack : MonoBehaviour {
	//Fades the screen to black

	public SpriteRenderer sr;

	public bool fading = false;
	float alpha;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer>();
		sr.color = new Color(1f, 1f, 1f, 0f);
		alpha = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(fading && sr.color.a < 1){
			alpha += Time.deltaTime/2;
			sr.color = new Color(1f, 1f, 1f, alpha);
		}

		if(Input.GetKeyDown(KeyCode.F)){
			fading = true;
		}
	}
}
