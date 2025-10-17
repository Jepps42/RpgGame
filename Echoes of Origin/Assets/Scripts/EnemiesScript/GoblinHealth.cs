using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GoblinController;
public class GoblinHealth : MonoBehaviour
{
    public Slider slider;

    public int health;

    public int GobsMaxHealth = 10;

    public GoblinController controller;
    // Start is called before the first frame update
    void Start()
    {
        health = GobsMaxHealth;
        slider.maxValue = GobsMaxHealth;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageTaken(int PlayerDamage)
    {
        health -= PlayerDamage;
        slider.value = health;

        if (health <= 0)
        {

            controller.EnemyStates(EnemyState.Dead);
        }
    }
}
