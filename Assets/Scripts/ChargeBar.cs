using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour {

	public Image bar;
	public static float points;
	public float maxpoint;

	public float ratioOfHeal;
	public float adjustFactor;
	// Use this for initialization
	void Start () {
		points = 100f;
		maxpoint = 100f;
		ratioOfHeal = 1.0f / ShieldPlayer.chargeTime;
	}
	
	// Update is called once per frame
	void Update () {





	}

	void FixedUpdate() {
		//20 sec recharge
		//if points is < 100f, means its charging. at 100, its charged
		if (points < 100f/adjustFactor) {
			points += ratioOfHeal;
			Debug.Log ("points " + points);
			float ratio = (points / maxpoint) * adjustFactor;

			if (ratio < 1f) {
				Debug.Log ("ratio" + ratio);
				bar.rectTransform.localScale = new Vector3(ratio, 1, 1);
			}

		}
	}
}
