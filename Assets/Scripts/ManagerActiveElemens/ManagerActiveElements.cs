using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerActiveElements : MonoBehaviour
{
    public Vector3 point1;
    public Vector3 point2;
    public float speed;                     // �������� ����������� ���������.
    public Vector3 target;                  // ���� (�����) � ������� �������� ���������.
    private void Reset()
    {
        point1 = transform.position;
        point2 = transform.position;
    }
    public virtual void Start()
    {
        target = point1;                    // ��������� ��������� ���� - minPointX.
    }

    public virtual void FixedUpdate()
    {
        PlatformMovementVertical();
    }

    /// <summary>
    /// ����� ������������� ����������� ��������� ����� ����� ������� minPointX � maxPointX.
    /// </summary>
    public virtual void PlatformMovementVertical()
    {

    }
}