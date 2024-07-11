using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GeometryForm player;                             // Обращение к коду игрока
    public GameObject prefabFire;                           // Префаб объекта используемого при атаке
    public Transform firePoint;                             // Точка появления префаба объекта используемого при атаке
    public Rigidbody2D fireball;                            //
    public float prefabFireSpeed;                           // Скорость префаба объекта используемого при атаке
    public float reloadTime;                                // Переменная отвечающая за время перезарядки выстрелов
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", reloadTime, reloadTime);    // Стрельба через определенный интервал времени.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Метод активирующий стрельбу летающим врагом.
    /// </summary>
    public void Fire()
    {
        GameObject fire = Instantiate(prefabFire, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.forward * prefabFireSpeed;
    }
}