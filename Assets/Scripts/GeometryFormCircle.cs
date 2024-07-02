using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormCircle : GeometryForm
{
    private int countNumberOfJumps;
    public float forceAdd;

    //protected override void Movement()
    //{
    //    base.Movement();
    //    if (Input.GetKeyDown(KeyCode.F))
    //    {
    //        if (isMovmentRight)
    //        {
    //            rb.AddForce(Vector2.right * forceAdd, ForceMode2D.Impulse);
    //        }
    //        else
    //        {
    //            rb.AddForce(Vector2.left * forceAdd, ForceMode2D.Impulse);
    //        }
    //    }
    //}

    /// <summary>
    /// �����, ���������� �� ������ �������� ���������. 
    /// </summary>
    protected override void Jump()
    {
        if (isGrounded == false && countNumberOfJumps > 1)
        {
            return;
        }
        rb.AddForce(new Vector2(0, formJumpHeight), ForceMode2D.Impulse);
        countNumberOfJumps += 1;
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
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        countNumberOfJumps = 0;
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
