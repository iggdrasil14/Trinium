using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormSquare : GeometryForm
{
    public float interactiveForce;
    public bool isCanDestroyBox;
    private bool isCanInteract;
    private Rigidbody2D interactiveObject;

    protected override void Update()
    {
        base.Update();
        if (Input.GetKey(KeyCode.R) && isCanInteract)
        {
            interactiveObject.bodyType = RigidbodyType2D.Dynamic;
            if (Input.GetKey(KeyCode.A))
            {
                interactiveObject.velocity = Vector2.left * interactiveForce;
                //interactiveObject.AddForce(Vector2.left * interactiveForce);
            }
            if (Input.GetKey(KeyCode.D))
            {
                interactiveObject.velocity = Vector2.right * interactiveForce;
                //interactiveObject.AddForce(Vector2.right * interactiveForce);
            }
        }
        else if (interactiveObject != null)
        {
            interactiveObject.bodyType = RigidbodyType2D.Kinematic;
        }
    }
    protected override void Transformation()
    {
        // ��������� ����� - �����������.
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
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

    public void LandingOnCollider(Collider2D collider)
    {
        print(collider.name);

        if(isCanDestroyBox == true)
        {
            if (collider.gameObject.tag == "BoxDestroy")
            {
                if (collider.gameObject.TryGetComponent<Rigidbody2D>(out var rb))
                {
                    rb.bodyType = RigidbodyType2D.Dynamic;
                    Destroy(collider.gameObject, 2);
                }
            }
            isCanAttack = true;
        }
        isCanDestroyBox = false;
    }
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if(other.gameObject.tag == "BoxInteractive")
        {
            isCanInteract = true;
            interactiveObject = other.GetComponentInParent<Rigidbody2D>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BoxInteractive")
        {
            isCanInteract = false;
            if(interactiveObject != null)
            {
                interactiveObject.velocity = Vector2.zero;
                interactiveObject.bodyType = RigidbodyType2D.Kinematic;
            }
            interactiveObject = null;
        }
    }
}
