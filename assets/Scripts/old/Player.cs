using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity;
    public int health;
    //private Vector3 direction;
    private Rigidbody2D rb;
    public GameObject explosion;
    
    private float tiltAroundZ;

    public float tiltAngle;

    public GameObject[] bullet;
    public GameObject[] bulletGenerator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = 10;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet[0], bulletGenerator[0].transform.position + transform.up, this.transform.rotation);
            //La Quaternion.identity es una rotacion en default es la del objeto que instancias
            //sin el this. es un quejica y no reconoce la rotacion de la nave
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet[1], bulletGenerator[1].transform.position, this.transform.rotation);
            Instantiate(bullet[1], bulletGenerator[2].transform.position, this.transform.rotation);
        }
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet[1], bulletGenerator.transform.position + new Vector3 (2,0,0) + transform.up, this.transform.rotation);
            Instantiate(bullet[1], bulletGenerator.transform.position - new Vector3 (2,0,0) + transform.up, this.transform.rotation);
        }*/
    }
    
    void FixedUpdate()
    {
        //direction = Vector3.zero;
        //direction.x = Input.GetAxisRaw("Horizontal");
        //direction.y = Input.GetAxisRaw("Vertical");

        tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

        transform.Rotate(0.0f,0.0f,tiltAroundZ, Space.World);

        if(Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(transform.position + transform.up * velocity * Time.deltaTime);
        }

        else if(Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(transform.position - transform.up * velocity * Time.deltaTime);
        }  

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("meteor"))
        {//other.tag.Equals("meteor");
            health += -1;
            /*var e = */Instantiate(explosion, transform.position, Quaternion.identity);
            //Destroy(e, 1.5f);
            Destroy(other.gameObject);
            if(health == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}