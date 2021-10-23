using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletVelocity;
    public GameObject explosion;
    private Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.up * BulletVelocity * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag.Equals("meteor"))
        {
            Instantiate(explosion, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if(other.tag.Equals("destroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}
