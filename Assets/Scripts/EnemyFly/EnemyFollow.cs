using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    Vector2 pointDestination;
    public Transform leftPoint;
    public Transform rightPoint;
    public float speed;
    private Vector3 _leftPointPosition;
    private Vector3 _rightPointPosition;
    private float _startPositionY;
    private bool _isPlayerInArea;
    IEnumerator Start()
    {
        _startPositionY = transform.position.y;
        _leftPointPosition = leftPoint.position;
        _rightPointPosition = rightPoint.position;
        yield return new WaitForEndOfFrame();
        GetRandomPoint();
    }
    // Update is called once per frame
    void Update()
    {
        if (_isPlayerInArea == false && (GeometryForm.Player.position.x > _leftPointPosition.x || GeometryForm.Player.position.x < _rightPointPosition.x))
        {
            GetRandomPoint();
            _isPlayerInArea = true;
        }
        else
        {
            _isPlayerInArea = false;
        }
        if(_isPlayerInArea == true)
        {
            float distance = Vector2.Distance(transform.position, pointDestination);
            if (distance <= 0.1f)
            {
                GetRandomPoint();
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, pointDestination, speed * Time.deltaTime);
                Vector3 currentPosition = transform.position;
                currentPosition.x = Mathf.Clamp(currentPosition.x, _leftPointPosition.x, _rightPointPosition.x);
                currentPosition.y = Mathf.Clamp(currentPosition.y, _leftPointPosition.y, _rightPointPosition.y);
                transform.position = currentPosition;
            }
        }
    }
    /// <summary>
    /// Получение случайно точки для врага
    /// </summary>
    private void GetRandomPoint()
    {
        Vector2 playerPosition = GeometryForm.Player.position;
        playerPosition.y = _startPositionY;
        pointDestination = playerPosition + Random.insideUnitCircle * 2;
    }
}
