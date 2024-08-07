using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormSquare : GeometryForm
{
    public float interactiveForce;
    public bool isCanDestroyBox;
    [SerializeField]private FixedJoint2D _fixedJoint2D;
    private bool isCanInteract;
    private RigidbodyConstraints2D _constraints;

    protected override void Update()
    {
        base.Update();
        // ���������� ������� ���������� � �������� � ����������.
        if (InputManager.Instance.DragAndPullInput == true && isCanInteract)
        {
            _fixedJoint2D.enabled = true;
            _fixedJoint2D.connectedBody = rb;
            _constraints = _fixedJoint2D.GetComponent<Rigidbody2D>().constraints;
            _fixedJoint2D.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        // ���������� ������� ���������� � �������� � ����������.
        else if (InputManager.Instance.DragAndPullInput == true && _fixedJoint2D != null)
        {
            _fixedJoint2D.enabled = false;
            _fixedJoint2D.connectedBody = null;
            _fixedJoint2D.GetComponent<Rigidbody2D>().constraints = _constraints;
        }
    }
    protected override void Transformation()
    {
        // ��������� ����� - �����������.
        if (InputManager.Instance.FormTriangleInput == true)
        {
            // ���������� ������� �����.
            Destroy(gameObject);
            // ���������� ����������, �������������� ��������� �����.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // ���������� ����� - �����������.
            Instantiate(prefabFormTriangle, transform.position, Quaternion.identity);
            return;
        }

        // ��������� ����� - ����.
        if (InputManager.Instance.FormCircleInput == true)
        {
            // ���������� ������� �����.
            Destroy(gameObject);
            // ���������� ����������, �������������� ��������� �����.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // ���������� ����� - ����.
            Instantiate(prefabFormCircle, transform.position, Quaternion.identity);
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
            _fixedJoint2D = other.GetComponentInParent<FixedJoint2D>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BoxInteractive")
        {
            isCanInteract = false;
            _fixedJoint2D = null;
            collision.GetComponentInParent<FixedJoint2D>().enabled = false;
        }
    }
}
