using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoblinController : MonoBehaviour
{
    public Slider slider;

    public Rigidbody2D Rb;

    public int health;

    public int GobsMaxHealth = 10;

    public float GoblinSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
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
            Destroy(gameObject);
        }
    }
}
