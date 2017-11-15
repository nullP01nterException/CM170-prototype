using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPlayer : MonoBehaviour {

	public bool active;
	public bool readyToUse;
	public Vector3 playerpos;
	public float activeTime;
	public static float chargeTime = 20f;

	// Use this for initialization
	void Start () {
		//active = false;
		readyToUse = true;
		//this.gameObject.SetActive (false);
		this.gameObject.transform.localScale = new Vector3 (0.001f, 0.001f, 0.001f);
		this.transform.localPosition = new Vector3 (-100f, -100f, -100f);
		activeTime = 10.0f;
		//chargeTime = 20.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && readyToUse) {
			Debug.Log ("Pressed key");
			activate ();
		}

		if (active) {
			this.gameObject.transform.Rotate (0f, 1f, 0f);
		}
	}

	void activate() {
		//this.gameObject.SetActive (true);
		ChargeBar.points = 0.001f;
		active = true;
		this.gameObject.transform.localScale = new Vector3 (130f, 130f, 130f);
		this.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
		readyToUse = false;
		StartCoroutine (toggleOff());
		StartCoroutine (coolDown ());
	}

	IEnumerator toggleOff() {
		yield return new WaitForSeconds (10.0f);
		this.gameObject.transform.localScale = new Vector3 (0.001f, 0.001f, 0.001f);
		this.transform.localPosition = new Vector3 (-100f, -100f, -100f);
		active = false;
		//this.gameObject.SetActive (false);
	}

	IEnumerator coolDown() {
		yield return new WaitForSeconds (chargeTime);
		readyToUse = true;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "obj")
		{
			Debug.Log("Shieldhit");
			Destroy(col.gameObject);
			//HealthBar.TakeCollisionHit();
			//col.gameObject.GetComponent<HealthBar>().hitpoints -= 25;
			// col.gameObject.GetComponent<HealthBar>().UpdateHealthbar(); 
		}
	}

	void onTriggerEnter(Collision col) {
		if (col.gameObject.tag == "obj")
		{
			Debug.Log("Shieldhit");
			Destroy(col.gameObject);
			//HealthBar.TakeCollisionHit();
			//col.gameObject.GetComponent<HealthBar>().hitpoints -= 25;
			// col.gameObject.GetComponent<HealthBar>().UpdateHealthbar(); 
		}
	}


}
