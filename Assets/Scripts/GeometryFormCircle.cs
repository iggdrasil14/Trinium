using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormCircle : GeometryForm
{
    private int countNumberOfJumps;
    public float forceAdd;

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
        // ��������� ����� - �������.
        if (InputManager.Instance.FormSquareInput == true)
        {
            // ���������� ������� �����.
            Destroy(gameObject);
            // ���������� ����������, �������������� ��������� �����.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // ���������� ����� - �������.
            Instantiate(prefabFormSquare, transform.position, Quaternion.identity);
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
