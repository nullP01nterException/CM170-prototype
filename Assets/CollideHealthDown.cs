using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideHealthDown : MonoBehaviour {

    public bool isHit;
    public float damage = 20;
	//public float damage = 0.001f;

    public void OnTriggerEnter(Collider col)
    {
		if (col.tag == "Player") {
			Debug.Log ("You are hit");
			col.SendMessage ((isHit) ? "TakeDamage" : "HealDamage");
			Destroy (this);
		} else {
			Destroy (this);
		}
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("You are hit 2");
            Destroy(this);
            //HealthBar.TakeCollisionHit();
            col.gameObject.GetComponent<HealthBar>().hitpoints -= 25;
            // col.gameObject.GetComponent<HealthBar>().UpdateHealthbar(); 
        }
    }

    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    //void Update () {

    //}s
}
