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


	void OnMouseEnter () {
		var mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float x = (float)Math.Sin(rigidbody2D.transform.position.x - mouse.x);
		float y = (float)Math.Sin(rigidbody2D.transform.position.y - mouse.y);
		rigidbody2D.velocity = new Vector2(x * ForceX,y * ForceY);
		int hitcount = int.Parse(hitcounter.guiText.text) + 1;
		hitcounter.guiText.text = hitcount.ToString();
		hitsound.audio.Play();
	}

	// Update is called once per frame  
	void Update() {

	}
}
