using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public Vector3 point1;                              // �����, ���� �� ����, ����� �������� ��������� ����.
    public Vector3 point2;                              // �����, ���� �� ����, ����� �������� ��������� ����.
    public Vector3 target;                              // ���� (�����) � ������� �������� ����.
    public int health;                                  // �������� �����.
    public float hightJump;                             // ������ ������
    public float speed;                                 // �������� ����������� �����.
    public float attackDistance;                        // ��������� ����� ����� ������ � �������.
    public AudioClip attackSound;                       // ���� �����
    private SpriteRenderer enemySR;                     // ��������� SpriteRenderer �����.
    private float jumpTimer;
    private bool isDeath;
    protected Animator animator;                        // �������� �����.
    protected Rigidbody2D rb;                           // ��������� Rigidbody �����.
    
    private void Reset()
    {
        point1 = transform.position;
        point2 = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();               // 
        animator = GetComponent<Animator>();            // 
        enemySR = GetComponent<SpriteRenderer>();       // ������������� SpriteRenderer.

        if (enemySR == null)
        {
            Debug.LogError("SpriteRenderer ��������� �� ������!");
        }

        target = point2;                                // ��������� ��������� ���� �������� �����.
    }

    // Update is called once per frame
    void Update()
    {
        if(isDeath == true)
        {
            return;
        }
        // �������� �� ����������� ���������� ������.
        if(jumpTimer <= Time.time)
        {
            if(Random.value <= 0.3f)
            {
                Jump();
            }
            jumpTimer = Time.time + 1f;
        }

        Walk();
        // �������� �� �����, ���� ����� ������� ������.
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
        // ����������� ����� � ����.
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (target != point1)
        {
            enemySR.flipX = true;
        }
        else
        {
            enemySR.flipX = false;
        }
        // ������������ ����, ���� ���� ������ ����������� ����.
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = target == point1 ? point2 : point1;
        }
    }

    public void Damage(int damage = 1)
    {
        health -= damage;
        if(health <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        animator.CrossFade("enemyDeath", 0);
        isDeath = true;
    }

    public void CompletedDeath()
    {
        Destroy(gameObject);
    }
    public void Attack()
    {
        animator.CrossFade("enemyAttack", 0);
    }

    public void PlayAttackSound()
    {
        AudioSource.PlayClipAtPoint(attackSound, transform.position);
    }
    public void Jump()
    {
        rb.AddForce(Vector2.up * hightJump, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<GeometryFormHP>(out var realHP))
        {
            realHP.Damage();
        }
    }
}
