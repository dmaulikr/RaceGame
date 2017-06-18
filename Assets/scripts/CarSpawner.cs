using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public GameObject[] cars;
	int No=0;
	float maxpos=2.1f;
	float timer=0.5f;   //the delay timer for each car to regenerate
	void Start () {

		}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;       //keep decreasing timer for each frame
		if (timer <= 0) {                   //spawn objects when timer becomes <=0 or after each 0.5 sec 
			Vector3 newpos = new Vector3(Random.Range (-maxpos, maxpos),transform.position.y,transform.position.z);
			Instantiate (cars[Random.Range(0,5)], newpos, transform.rotation);
			timer = 1f;
		}
		
	}
}
