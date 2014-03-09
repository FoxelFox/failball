using UnityEngine;
using System.Collections;

public class hitcounterupdate : MonoBehaviour {

	public GameObject hitcounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hitcounter.guiText.text = guiText.text;
	}
}
