using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image currentHealthbar;
    public GameManager theGameManager;
    //public Material materialHealthbar;
    public Color highHealthColor;
    public Color halfHealthColor;
    public Color quarterHealthColor;
    //public Text debugText;

    public GameObject audioSource;
    private AudioLowPassFilter lpf;

    public float hitpoints = 100;
    public float maxHitpoint = 100;

    // Use this for initialization
    void Start()
    {
        UpdateHealthbar();

        lpf = audioSource.GetComponent<AudioLowPassFilter>();
        lpf.cutoffFrequency = 22000;
    }

    public void UpdateHealthbar()
    {
        float ratio = hitpoints / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        // print("ratio " + ratio);
        //debugText.text = ratio.ToString(); // =(ratio * 100).ToString() + '%';
        if (ratio <= 0.25f) // probably will want to tweak this
        {
            // set Healthbar color to red
            if (currentHealthbar.color != quarterHealthColor)
            {
                currentHealthbar.color = quarterHealthColor;
            }
        }
        else if (ratio <= 0.5f) // probably will want to tweak this
        {
            // set Healthbar color to yellow
            if (currentHealthbar.color != halfHealthColor)
            {
                currentHealthbar.color = halfHealthColor;
            }

        }
        else
        {
            // set Healthbar color to green
            currentHealthbar.color = highHealthColor;
        }
    }

    private void TakeDamage(float damage)
    {
        lpf.cutoffFrequency /= 1.5f;
        hitpoints -= damage;
        if (hitpoints < 0)
        {
            hitpoints = 0;
            Debug.Log("You are Dead, Dead, Dead");
            theGameManager.RestartGame();
        }
        UpdateHealthbar();
    }


    private void HealDamage(float heal)
    {

    }

    // Update is called once per frame
    //void Update () {	
    //}
}