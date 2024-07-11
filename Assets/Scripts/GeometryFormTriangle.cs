using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormTriangle : GeometryForm
{
    protected override void Transformation()
    {
        // Активация формы - квадрат.
        if (InputManager.Instance.FormSquareInput == true)
        {
            // Уничтожает текущую форму.
            Destroy(gameObject);
            // Активирует спецэффект, сопровождающий изменение формы.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // Активирует форму - квадрат.
            Instantiate(prefabFormSquare, transform.position, Quaternion.identity);
            return;
        }

        // Активация формы - круг.
        if (InputManager.Instance.FormCircleInput == true)
        {
            // Уничтожает текущую форму.
            Destroy(gameObject);
            // Активирует спецэффект, сопровождающий изменение формы.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // Активирует форму - круг.
            Instantiate(prefabFormCircle, transform.position, Quaternion.identity);
        }
    }

}
