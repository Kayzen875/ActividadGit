using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSystem : MonoBehaviour
{
    private Transform target;

    [SerializeField]
    private float speed;

    public void Tracking()
    {
        target = GameObject.Find("Meteorito").transform;
        /*target = GameObject.FindWithTag("meteor").transform;
        Vector3.Distance(target.position, transform.position)*/
    }

    void FixedUpdate()
    {
        if(target != null)
        {
            float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, angle);
            //transform.Rotate(angle, new Vector3(0,0,1));
        }
    }
}
