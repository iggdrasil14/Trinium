using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormCircle : GeometryForm
{
    private int countNumberOfJumps;
    public float forceAdd;

    /// <summary>
    /// Метод, отвечающий за прыжок игрового персонажа. 
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
        // Активация формы - треугольник.
        //if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        if (InputManager.Instance.FormTriangleInput == true)
        {
            // Уничтожает текущую форму.
            Destroy(gameObject);
            // Активирует спецэффект, сопровождающий изменение формы.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // Активирует форму - треугольник.
            Instantiate(prefabFormTriangle, transform.position, Quaternion.identity);
            Debug.Log("Активация треугольника");
            return;
        }
        // Активация формы - квадрат.
        //if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        if (InputManager.Instance.FormSquareInput == true)
        {
            // Уничтожает текущую форму.
            Destroy(gameObject);
            // Активирует спецэффект, сопровождающий изменение формы.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // Активирует форму - квадрат.
            Instantiate(prefabFormSquare, transform.position, Quaternion.identity);
            Debug.Log("Активация квадрата");
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
