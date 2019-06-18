using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayHealthBar : MonoBehaviour
{
    [Header("Reference to health")]
    // Player maximum health
    public float maxHealth;
    // Player current health
    public float curHealth;
    // Reference to delay health
    public float delayHealth;
    
    [Header("Delay Drop Speed")]
    // Speed of delay health
    public float speed = 20;

    [Header("Reference to UI elements")]
    // Reference to Slider
    public Slider healthSlider;
    // Reference to Fill
    public Image healthFill;
    // Reference to Delay Slider
    public Slider DelaySlider;
    // Reference to Delay Fill
    public Image DelayFill;

    void Update()
    {
        // Value of current health and max health
        healthSlider.value = Mathf.Clamp01(curHealth / maxHealth);
        if(delayHealth > curHealth)
        {
            delayHealth -= Time.deltaTime * speed;
        }
        DelaySlider.value = Mathf.Clamp01(delayHealth / maxHealth);
        ManageHealthBar();
    }



    void ManageHealthBar() {

        if (curHealth <= 0 && healthFill.enabled)
        {
            healthFill.enabled = false;
        }
        // If the player health is 0 then he dies
        else if (curHealth <= 0 && healthFill.enabled)
        {
            Debug.Log("Dead");
            healthFill.enabled = false;
        }
        // If the player health is higher than 0 he is alive
        if (!healthFill.enabled && curHealth > 0)
        {
            Debug.Log("Revive");
            healthFill.enabled = enabled;
        }
        else if (delayHealth < curHealth)
        {
            healthFill.enabled = enabled;
            delayHealth = curHealth;
            DelaySlider.value = healthSlider.value;
        }
    }
    //ForGround Fill (current)
    //Background Fill (delay)
    //Health background changes but need to stay the same at 0 and max
    //If our current health is less than delay health we need to bring or health down by our speed overtime to match the current
    //set delay slider value to be equal to the delay health value, and not exceed the minimum and maximun value
    /////
    //EXTRA - To manage the healthbar make sure forgraund fill is exced to forgraund health and enable on revive
    //once delay is empty turn off background delay upon revive turn on fill and make sure delay health and value are 4
}
