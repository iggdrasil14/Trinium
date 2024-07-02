using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeometryFormHP : MonoBehaviour
{
    public int health;
    public CharacterController2D characterController;

    public void Damage(int damage = 1)
    {
        if(characterController.IsDashing) return;
        health -= damage;
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)                         
    {
        if(collision.tag == "Trap" && characterController.IsDashing == false)   // ѕроверка на взаимодействие с ловушкой (trap).
        {
            Damage();
        }
    }
}
