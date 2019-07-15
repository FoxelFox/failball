using UnityEngine;
using System.Collections;
using System;

public class PushBall : MonoBehaviour {
	public float ForceX;
	public float ForceY;
	public GameObject hitcounter;
	public GameObject hitsound;

	private DateTime clickTime;

	// Use this for initialization
	void Start () {

	}

	void OnMouseDown() {
		clickTime = System.DateTime.Now;
	}

	/// <summary>
	/// If the mouse has entered the object:
	/// 	- apply a force on that object
	/// 	- set hitcounter
	/// 	- play a sound
	/// </summary>
	void OnMouseEnter () {

		var cTime = System.DateTime.Now;
		//if((cTime - clickTime).Milliseconds < 500) {

			// convert mouseposition to worldcoordinates
			var mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			// calculate the force vector and apply it to the velocity
			float x = (float)Math.Sin(GetComponent<Rigidbody2D>().transform.position.x - mouse.x);
			float y = (float)Math.Sin(GetComponent<Rigidbody2D>().transform.position.y - mouse.y);
			GetComponent<Rigidbody2D>().velocity = new Vector2(x * ForceX,y * ForceY);

			// set hit counter
			int hitcount = int.Parse(hitcounter.GetComponent<GUIText>().text) + 1;
			hitcounter.GetComponent<GUIText>().text = hitcount.ToString();

			// play a sound
			hitsound.GetComponent<AudioSource>().Play();
		//}
	}

	// Update is called once per frame  
	void Update() {

	}
}
