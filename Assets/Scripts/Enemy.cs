using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public Vector3 point1;                              // Точка, одна из двух, между которыми двигается враг.
    public Vector3 point2;                              // Точка, одна из двух, между которыми двигается враг.
    public Vector3 target;                              // Цель (точка) к которой движется враг.
    public int health;                                  // Здоровье врага.
    public float speed;                                 // Скорость перемещения врага.
    public float attackDistance;                        // Дистанция атаки между врагом и Игроком.
    private SpriteRenderer enemySR;                     // Компонент SpriteRenderer врага.
    protected Animator animator;                        // Аниматор врага.
    protected Rigidbody2D rb;                           // Компонент Rigidbody врага.
    
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
        enemySR = GetComponent<SpriteRenderer>();        // Инициализация SpriteRenderer.

        if (enemySR == null)
        {
            Debug.LogError("SpriteRenderer компонент не найден!");
        }

        target = point2;                                // Установка начальной цели движения врага.
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        // Проверка на атаку, если Игрок подошел близко.
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
        // Перемещение врага к цели.
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (target != point1)
        {
            enemySR.flipX = true;
        }
        else
        {
            enemySR.flipX = false;
        }
        // Переключение цели, если враг достиг изначальной цели.
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = target == point1 ? point2 : point1;
           
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
