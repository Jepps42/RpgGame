using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoblinController : MonoBehaviour
{

    public Rigidbody2D Rb;

    public float GoblinSpeed = 6;

    public EnemyState enemyState = EnemyState.Idle;

    private Animator EnemyAnim;
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
}
