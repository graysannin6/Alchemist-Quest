using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb { get; private set; }
    public Animator anim { get; private set; }

    public EnemyStateMachine stateMachine { get; private set; }

    public void Awake()
    {
        stateMachine = new EnemyStateMachine();
    }

    public void Update()
    {
        stateMachine.currentState.Update();
    }
}