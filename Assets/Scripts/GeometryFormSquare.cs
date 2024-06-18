using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFormSquare : GeometryForm
{
    public bool isCanDestroyBox;
    protected override void Transformation()
    {
        // Активация формы - треугольник.
        if (Input.GetKeyDown(KeyCode.Keypad1))
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
