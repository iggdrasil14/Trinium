using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormSquare : GeometryForm
{
    public bool isCanDestroyBox;
    protected override void Transformation()
    {
        // ��������� ����� - �����������.
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            // ���������� ������� �����.
            Destroy(gameObject);
            // ���������� ����������, �������������� ��������� �����.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // ���������� ����� - �����������.
            Instantiate(prefabFormTriangle, transform.position, Quaternion.identity);
            Debug.Log("��������� ������������");
            return;
        }

        // ��������� ����� - ����.
        if (Input.GetKeyDown(KeyCode.Keypad3))
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

    public void LandingOnCollider(Collider2D collider)
    {
        print(collider.name);

        if(collider.gameObject.tag == "BoxDestroy" && isCanDestroyBox == true)
        {
            if(collider.gameObject.TryGetComponent<Rigidbody2D>(out var rb))
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
                Destroy(collider.gameObject, 2);
            }
        }

        isCanDestroyBox = false;
    }
}
