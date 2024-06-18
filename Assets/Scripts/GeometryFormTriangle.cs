using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormTriangle : GeometryForm
{
    protected override void Transformation()
    {
        // Активация формы - квадрат.
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            // Уничтожает текущую форму.
            Destroy(gameObject);
            // Активирует спецэффект, сопровождающий изменение формы.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // Активирует форму - квадрат.
            Instantiate(prefabFormSquare, transform.position, Quaternion.identity);
            Debug.Log("Активация квадрата");
            return;
        }

        // Активация формы - круг.
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            // Уничтожает текущую форму.
            Destroy(gameObject);
            // Активирует спецэффект, сопровождающий изменение формы.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // Активирует форму - круг.
            Instantiate(prefabFormCircle, transform.position, Quaternion.identity);
            Debug.Log("Активация круга");
        }
    }
}
