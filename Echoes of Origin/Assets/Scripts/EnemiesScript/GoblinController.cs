using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : MonoBehaviour
{

    public Rigidbody2D Rb;

    public int health;

    public int GobsMaxHealth = 10;

    public float GoblinSpeed = 6;

    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        health = GobsMaxHealth;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageTaken(int PlayerDamage)
    {
        health -= PlayerDamage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
