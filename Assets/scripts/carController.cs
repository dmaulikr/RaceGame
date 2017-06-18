using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

	public float carspeed;
	Vector2 pos;
	void Start () {
		pos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		pos.x += Input.GetAxis ("Horizontal") * carspeed * Time.deltaTime;
		pos.x=Mathf.Clamp(pos.x,-2.10f,2.10f);
		transform.position = pos;
	}
   void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "enemy")
			Destroy (gameObject);
	}
}
