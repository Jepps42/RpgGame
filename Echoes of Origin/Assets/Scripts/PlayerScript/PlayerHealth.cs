using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int Health;

    public int PlayerMaxHealth = 10;

    public Slider PlayerUIHealth;
    // Start is called before the first frame update
    void Start()
    {
        Health = PlayerMaxHealth;
        PlayerUIHealth.maxValue = PlayerMaxHealth;
        PlayerUIHealth.value = Health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int GoblinDamage)
    {
        Health -= GoblinDamage;
        PlayerUIHealth.value = Health;

        if (Health <= 0)
        {

            Destroy(gameObject);
        }
    }
}
