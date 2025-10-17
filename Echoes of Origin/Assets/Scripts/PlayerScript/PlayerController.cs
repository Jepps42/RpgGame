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

    public int PlayerHealth;

    public int PlayerMaxHealth = 10;

    public int PlayerDamage = 3;

    public GoblinController GobsHealth;
    //Until my floor is made, this will be commented out - JE
    //public bool isGrounded = true;

    //Dont need to face left if no enemies are there - JE
    //public bool FacingLeft = false;

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
        PlayerState state = PlayerState.Idle;
        Vector2 vel = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
            state = PlayerState.Walking;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
            state = PlayerState.Walking;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
            state = PlayerState.Walking;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
            state = PlayerState.Walking;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            vel.x += Speed;
            state = PlayerState.Running;
        }
        if (Input.GetKey(KeyCode.E))
        {

            state = PlayerState.Attacking;
        }
        /*if (Input.GetKey(KeyCode.Space)) 
        {
            state = PlayerState.Jumping;
        }*/ //Dont need jumping now - JE
        if (Input.GetKey(KeyCode.F))
        {
            state = PlayerState.Blocking;
        }

        RB.velocity = vel;

        State = state;


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
                    Anim.Play("Running");
                    break;
                }
            case PlayerState.Jumping:
                {
                    //Code for jumping animation - JE
                    Anim.Play("Jumping");
                    break;
                }
            case PlayerState.Attacking:
                {
                    //Code for attack animations - JE
                    Anim.Play("Attacking");
                    break;
                }
            case PlayerState.Blocking:
                {
                    //Code for blocking animation - JE
                    Anim.Play("Blocking");
                    break;
                }
            case PlayerState.Stunned:
                {
                    //Code for stunned animation state - JE
                    Anim.Play("Stunned");
                    break;
                }
        }
    }

    public void TakeDamage(int damage) 
    {
        PlayerHealth -= damage;

        if (PlayerHealth <= 0) 
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Goblin")
        {
            GobsHealth.DamageTaken(PlayerDamage);
        }
    }
}
