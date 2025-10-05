using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB;

    public PlayerState State = PlayerState.Idle;

    private Animator Anim; 

    private float Speed = 8;

    public float Bounce = 7;

    //Until my floor is made, this will be commented out - JE
    //public bool isGrounded = true;

    public bool isSprinting = false;

    public bool FacingLeft = false;

    public bool FacingRight = false;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }


    //Enums are a way of identifying what state player is in, enums have to be written out before used as variable - JE
    public enum PlayerState
    {
        None = 0,
        Idle = 1,
        Walking = 2,
        Running = 3,
        Jumping = 4,
        Attacking = 5,
        Blocking = 6,
        Stunned = 7
    }

    // Update is called once per frame
    //Alternative method of player movement rather than transform - JE
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
            FacingLeft = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
            FacingRight = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
        }

        RB.velocity = vel;

        switch (State)
        {
            case PlayerState.Idle:
                {
                    //Code for idle animation state - JE
                    Anim.Play("Idle");
                    break;
                }
            case PlayerState.Walking:
                {
                    //Code for walking animation - JE
                    Anim.Play("Walking");
                    break;
                }
            case PlayerState.Running:
                {
                    //Code for running animation - JE
                    break;
                }
            case PlayerState.Jumping:
                {
                    //Code for jumping animation - JE
                    break;
                }
            case PlayerState.Attacking:
                {
                    //Code for attack animations - JE
                    break;
                }
            case PlayerState.Blocking:
                {
                    //Code for blocking animation - JE
                    break;
                }
            case PlayerState.Stunned: 
                {
                    //Code for stunned animation state - JE
                    break;
                }
        }
    }
}
