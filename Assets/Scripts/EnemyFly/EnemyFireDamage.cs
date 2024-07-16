using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        if (collision.gameObject.TryGetComponent<GeometryFormHP>(out GeometryFormHP hp))
        {
            hp.Damage(1);
        }
    }
}
