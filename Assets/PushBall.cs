using UnityEngine;
using System.Collections;
using System;

public class PushBall : MonoBehaviour {
	public float ForceX;
	public float ForceY;

	// Use this for initialization
	void Start () {

	}


	void OnMouseEnter () {
		var mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float x = (float)Math.Sin(rigidbody2D.transform.position.x - mouse.x);
		float y = (float)Math.Sin(rigidbody2D.transform.position.y - mouse.y);
		rigidbody2D.velocity = new Vector2(x * ForceX,y * ForceY);
	}

	// Update is called once per frame  
	void Update() {

	}
}
