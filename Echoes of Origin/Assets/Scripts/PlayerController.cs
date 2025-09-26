using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB;

    private float Speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += Speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
