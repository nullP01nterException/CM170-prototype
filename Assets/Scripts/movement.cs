using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	private float mx;
	// Use this for initialization
	void Start () {
		mx = 3;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			if (transform.position.x < mx) {
				transform.position = new Vector3 (transform.position.x + mx, transform.position.y, transform.position.z);
			}
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			if (transform.position.x > -mx) {
				transform.position = new Vector3 (transform.position.x - mx, transform.position.y, transform.position.z);
			}
		}
	}

	void OnTriggerEnter(Collider collisionInfo){
		print ("here");
	}
}
