using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestoreHealthSystem : MonoBehaviour
{
    public int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out HealthSystem h))
        {
            h.RestoreHealth(health);
        }

        Destroy(this.gameObject);
    }
}
