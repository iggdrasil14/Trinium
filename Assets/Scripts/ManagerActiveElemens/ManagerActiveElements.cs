using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerActiveElements : MonoBehaviour
{
    public Vector3 point1;
    public Vector3 point2;
    public float speed;                     // Скорость перемещения платформы.
    public Vector3 target;                  // Цель (точка) к которой движется платформа.
    private void Reset()
    {
        point1 = transform.position;
        point2 = transform.position;
    }
    public virtual void Start()
    {
        target = point1;                    // Установка начальной цели - minPointX.
    }

    public virtual void FixedUpdate()
    {
        PlatformMovementVertical();
    }

    /// <summary>
    /// Метод вертикального перемещения платформы между двумя точками minPointX и maxPointX.
    /// </summary>
    public virtual void PlatformMovementVertical()
    {

    }
}