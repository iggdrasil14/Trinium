using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GeometryForm player;                             // ��������� � ���� ������
    public GameObject prefabFire;                           // ������ ������� ������������� ��� �����
    public Transform firePoint;                             // ����� ��������� ������� ������� ������������� ��� �����
    public Rigidbody2D fireball;                            //
    public float prefabFireSpeed;                           // �������� ������� ������� ������������� ��� �����
    public float reloadTime;                                // ���������� ���������� �� ����� ����������� ���������
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", reloadTime, reloadTime);    // �������� ����� ������������ �������� �������.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// ����� ������������ �������� �������� ������.
    /// </summary>
    public void Fire()
    {
        GameObject fire = Instantiate(prefabFire, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.forward * prefabFireSpeed;
    }
}