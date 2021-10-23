using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootUpSystem : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out ShipController h))
       {
            h.shootUP();
        }
    }
}
