using UnityEngine;
using System.Collections;
using System;

public class PushBall : MonoBehaviour {
	public float ForceX;
	public float ForceY;
	public GameObject hitcounter;
	public GameObject hitsound;

	// Use this for initialization
	void Start () {

	}

	/// <summary>
	/// If the mouse has entered the object:
	/// 	- apply a force on that object
	/// 	- set hitcounter
	/// 	- play a sound
	/// </summary>
	void OnMouseEnter () {
		// convert mouseposition to worldcoordinates
		var mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		// calculate the force vector and apply it to the velocity
		float x = (float)Math.Sin(rigidbody2D.transform.position.x - mouse.x);
		float y = (float)Math.Sin(rigidbody2D.transform.position.y - mouse.y);
		rigidbody2D.velocity = new Vector2(x * ForceX,y * ForceY);

		// set hit counter
		int hitcount = int.Parse(hitcounter.guiText.text) + 1;
		hitcounter.guiText.text = hitcount.ToString();

		// play a sound
		hitsound.audio.Play();
	}

	// Update is called once per frame  
	void Update() {

	}
}
