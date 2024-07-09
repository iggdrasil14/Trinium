using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GeometryForm player;
    public Rigidbody2D fireball;
    public float reloadTime;            // Перезарядка
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", reloadTime, reloadTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        // инициализация
    }
}
