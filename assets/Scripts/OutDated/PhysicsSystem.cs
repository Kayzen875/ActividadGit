using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PhysicsSystem : MonoBehaviour
{
    public int damage;
    public event Action onHit = delegate { };

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag.Equals("meteor"))
        {
            Destroy(other.gameObject);
        }
        //onHit();
    }
}
