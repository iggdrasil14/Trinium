using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMainCamera : MonoBehaviour
{
    public Transform target;                    // ����, �� ������� ����� ��������� ������.
    public Transform leftCameraPoint;           // �����, �������������� �������� ������ �����.
    public Transform rightCameraPoint;          // �����, �������������� �������� ������ ������.
    public Transform topCameraPoint;            // �����, �������������� �������� ������ ������.
    public Transform buttomCameraPoint;         // �����, �������������� �������� ������ �����.
    public Vector2 offset;                      // �������� ������ ������������ ����.
    public float smoothSpeed = 0.125f;          // �������� � ������� ������ ����� ��������� �� �����.
    public float cameraZOffset = -10f;          // �������� ������ �� ��� Z ��� 2D.

    void FixedUpdate()
    {
        if (target == null) return;

        // �������� ������� ������ � ������ ������ �������������� ������� ���������
        Vector3 desiredPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, cameraZOffset);

        if (desiredPosition.x < leftCameraPoint.position.x)
        {
            desiredPosition.x = leftCameraPoint.position.x;
        }
        else if (desiredPosition.x > rightCameraPoint.position.x)
        {
            desiredPosition.x = rightCameraPoint.position.x;
        }
        if (desiredPosition.y < buttomCameraPoint.position.y)
        {
            desiredPosition.y = buttomCameraPoint.position.y;
        }
        if (desiredPosition.y > topCameraPoint.position.y)
        {
            desiredPosition.y = topCameraPoint.position.y;
        }

        // ������� ����������� � �������� �������
        Vector3 smoothedPosition = Vector3.Slerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
