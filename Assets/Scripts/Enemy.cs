using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float attackDistance;
    protected Animator animator;
    protected Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, GeometryForm.Player.position);
        if (distance <= attackDistance)
        {
            Attack();
        }
        
    }

    public void Idle()
    {

    }

    public void Walk()
    {

    }

    public void Death()
    {

    }

    public void Attack()
    {
        animator.CrossFade("enemyAttack", 0);
    }

    public void Jump()
    {

    }


}
