using UnityEngine;
using System.Collections;

public class groundscript : MonoBehaviour {

	public GameObject ball;
	public GameObject losertext;

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Ball")
		{
			Destroy(col.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
