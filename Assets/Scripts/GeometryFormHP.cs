using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeometryFormHP : MonoBehaviour
{
    public int health;

    public void Damage(int damage = 1)
    {
        health -= damage;
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
