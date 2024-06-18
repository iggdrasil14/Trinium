using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMainCamera : MonoBehaviour
{
    public Transform target;                    // ÷ель, за которой будет следовать камера.
    public Transform leftCameraPoint;           // “очка, ограничивающа€ основную камеру слева.
    public Transform rightCameraPoint;          // “очка, ограничивающа€ основную камеру справа.
    public Transform topCameraPoint;            // “очка, ограничивающа€ основную камеру сверху.
    public Transform buttomCameraPoint;         // “очка, ограничивающа€ основную камеру снизу.
    public Vector2 offset;                      // —мещение камеры относительно цели.
    public float smoothSpeed = 0.125f;          // —корость с которой камера будет следовать за целью.
    public float cameraZOffset = -10f;          // —мещение камеры по оси Z дл€ 2D.

    void FixedUpdate()
    {
        if (target == null) return;

        // ∆елаема€ позици€ камеры с учетом только горизонтальной позиции персонажа
        Vector3 desiredPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, cameraZOffset);

        if (desiredPosition.x < leftCameraPoint.position.x)
        {
            desiredPosition.x = leftCameraPoint.position.x;
        }
        else if (desiredPosition.x > rightCameraPoint.position.x)
        {
            desiredPosition.x = rightCameraPoint.position.x;
        }
        if (desiredPosition.y < buttomCameraPoint.position.y)
        {
            desiredPosition.y = buttomCameraPoint.position.y;
        }
        if (desiredPosition.y > topCameraPoint.position.y)
        {
            desiredPosition.y = topCameraPoint.position.y;
        }

        // ѕлавное перемещение к желаемой позиции
        Vector3 smoothedPosition = Vector3.Slerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
