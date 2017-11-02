using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideHealthDown : MonoBehaviour {

    public bool isHit;
    public float damage = 20;

    public void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("You are hit");
            col.SendMessage((isHit) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
        }
    }

    // Use this for initialization
    //void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
