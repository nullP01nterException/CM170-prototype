using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class effectManager : MonoBehaviour {

    public GameObject audioSource;
    private AudioLowPassFilter lpf;

	// Use this for initialization
	void Start () {
        lpf = audioSource.GetComponent<AudioLowPassFilter> ();
        lpf.cutoffFrequency = 22000;
	}
	
	// Update is called once per frame
	void Update () {

        lpf.cutoffFrequency /= 2;
	}
}
