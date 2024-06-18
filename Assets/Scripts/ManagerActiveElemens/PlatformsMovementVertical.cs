using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsMovementVertical : ManagerActiveElements
{
    public override void FixedUpdate()
    {
        // ���������� ��������� � ����.
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        // ���� ��������� ��������� ����, ����������� ����.
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = target == point1 ? point2 : point1;
        }

    }
}
