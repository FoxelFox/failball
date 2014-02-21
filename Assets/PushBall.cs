using UnityEngine;
using System.Collections;
using System;

public class PushBall : MonoBehaviour {
	public float forcey;
	public float forcex;
	// Use this for initialization
	void Start () {

	}

	void OnMouseDown() {
		rigidbody2D.velocity = new Vector2(0.0f, forcey);
		//RaycastHit2D hit;

	}

	// Update is called once per frame  
	void Update() {

	}
}
