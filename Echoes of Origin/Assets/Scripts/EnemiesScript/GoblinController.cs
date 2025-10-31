using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoblinController : MonoBehaviour
{
    public GameObject Player;

    public Rigidbody2D Rb;

    public float GoblinSpeed;

    public int GoblinDamage = 1;

    public EnemyState enemyState = EnemyState.Idle;

    private Animator EnemyAnim;

    private float distance;

    public PlayerHealth PlayerHealth;
    public enum EnemyState
    {
        Idle = 0,
        Hurt = 1,
        Chasing = 2,
        Attack = 3,
        Dead = 4
    }
    // Start is called before the first frame update
    void Start()
    {
        EnemyAnim = GetComponent<Animator>();
        Rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, GoblinSpeed * Time.deltaTime);

        if(enemyState == EnemyState.Dead)
        {
            return;
        }

        EnemyState tempState = EnemyState.Idle;
        EnemyStates(tempState);


    }


    public void EnemyStates(EnemyState tempState)
    {
        enemyState = tempState;

        switch (enemyState)
        {
            case EnemyState.Idle:
                EnemyAnim.Play("Idle");
                break;

            case EnemyState.Chasing:
                EnemyAnim.Play("Chase Player");
                break;

            case EnemyState.Attack:
                EnemyAnim.Play("Attack");
                break;

            case EnemyState.Dead:
                EnemyAnim.Play("Death");
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth.TakeDamage(GoblinDamage);
        }
    }
}
