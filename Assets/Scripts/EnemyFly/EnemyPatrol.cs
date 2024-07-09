using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] points;
    public float speed;
    private int _pointIndex;
    
    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, points[_pointIndex].position);
        transform.position = Vector2.MoveTowards(transform.position, points[_pointIndex].position, speed * Time.deltaTime);
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
