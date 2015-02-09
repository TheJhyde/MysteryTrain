using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {
	//moves the camera when players get to the side of the screen
	//Keeps it from moving too far or not far enough.

	public float speed = 5;
	public float gap = 15;

	public GameObject scene;
	CursorHandler cursor;

	float xMin;
	float xMax;

	// Use this for initialization
	void Start () {
		SpriteRenderer sceneRend = scene.GetComponent<SpriteRenderer>();

		xMin = (sceneRend.bounds.extents.x * -1) - Camera.main.ScreenToWorldPoint(Vector2.zero).x + 0.1f;
		xMax = (sceneRend.bounds.extents.x) + Camera.main.ScreenToWorldPoint(Vector2.one).x - 0.1f;

		transform.position = new Vector3(xMin, 0, -10);

		cursor = GameObject.Find("Cursor").GetComponent<CursorHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.mousePosition.x < gap && transform.position.x >= xMin){
			transform.position += new Vector3(speed*Time.deltaTime*-1, 0, 0);
			cursor.switchCursor(3);
		}else if(Input.mousePosition.x > Camera.main.pixelWidth - gap && transform.position.x <= xMax){
			transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
			cursor.switchCursor(4);
		}
	}
}
