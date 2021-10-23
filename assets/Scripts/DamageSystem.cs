using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageSystem : MonoBehaviour
{
    [SerializeField]
    public int damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.TryGetComponent(out HealthSystem h))
       {
            h.Hitted(damage);
        }  
    }
}
