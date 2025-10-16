using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoblinHealth : MonoBehaviour
{
    //Prioritize goblin script, health and player attacking - JE
    private Slider HealthBar;

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        HealthBar.value = currentValue / maxValue;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
