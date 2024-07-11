using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] points;              // —оздание массива points (с точками 0, 1, 2).
    public float speed;                     // —корость перемещени€ летающего врага.
    private int _pointIndex;                // “екущий номер элемента в массиве points.
    
    // Update is called once per frame
    void Update()
    {
        // ќпределение дистанции между двум€ точками (текущей и следующей точки из массива)
        float distance = Vector2.Distance(transform.position, points[_pointIndex].position);
        // ѕеремещение в направлении из текущей точки к следующей точки из массива с определенной скоростью
        transform.position = Vector2.MoveTowards(transform.position, points[_pointIndex].position, speed * Time.deltaTime);
        // ѕроверка на выполнение условий смены текущей точки на следующую из масиива (0, 1, 2, 0, 1, 2)
        if(distance <= 0.1f)
        {
            _pointIndex++;
            if(_pointIndex >= points.Length)
            {
                _pointIndex = 0;
            }
        }
    }
}
