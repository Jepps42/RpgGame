using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : MonoBehaviour
{

    public Rigidbody2D Rb;


    public float GobsMaxHealth = 5;

    public float GoblinSpeed = 6;

    public GoblinHealth heatlh;

    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        heatlh = GetComponentInChildren<GoblinHealth>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
