using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MissileUpSystem : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out ShipController h))
       {
            h.missileUP();
        }
    }
}
