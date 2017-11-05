﻿using System.Collections;
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