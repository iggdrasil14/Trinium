using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 point1;                              // �����, ���� �� ����, ����� �������� ��������� ����.
    public Vector3 point2;                              // �����, ���� �� ����, ����� �������� ��������� ����.
    public Vector3 target;                              // ���� (�����) � ������� �������� ����.
    public int health;                                  // �������� �����.
    public float speed;                                 // �������� ����������� �����.
    public float attackDistance;                        // ��������� ����� ����� ������ � �������.
    private SpriteRenderer enemySR;                     // ��������� SpriteRenderer �����.
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
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        enemySR = GetComponent<SpriteRenderer>();        // ������������� SpriteRenderer.

        if (enemySR == null)
        {
            Debug.LogError("SpriteRenderer ��������� �� ������!");
        }

        target = point2;                                // ��������� ��������� ���� �������� �����.
    }

    // Update is called once per frame
    void Update()
    {
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

        // ������������ ����, ���� ���� ������ ����������� ����.
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = target == point1 ? point2 : point1;
            if (target != point1)
            {
                enemySR.flipX = true;
            }
            if (target != point2)
            {
                enemySR.flipX = false;
            }
        }
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
