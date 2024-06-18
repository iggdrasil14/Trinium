using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;    

    public void Move(int side)
    {
        transform.position += Vector3.right * speed * side * Time.deltaTime;
    }
}
