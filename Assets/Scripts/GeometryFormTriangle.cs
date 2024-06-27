using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormTriangle : GeometryForm
{
    protected override void Transformation()
    {
        // ��������� ����� - �������.
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            // ���������� ������� �����.
            Destroy(gameObject);
            // ���������� ����������, �������������� ��������� �����.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // ���������� ����� - �������.
            Instantiate(prefabFormSquare, transform.position, Quaternion.identity);
            Debug.Log("��������� ��������");
            return;
        }

        // ��������� ����� - ����.
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            // ���������� ������� �����.
            Destroy(gameObject);
            // ���������� ����������, �������������� ��������� �����.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // ���������� ����� - ����.
            Instantiate(prefabFormCircle, transform.position, Quaternion.identity);
            Debug.Log("��������� �����");
        }
    }
}
