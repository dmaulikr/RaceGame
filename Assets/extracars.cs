using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extracars : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "enemy")
			Destroy (c.gameObject);
	}
}
