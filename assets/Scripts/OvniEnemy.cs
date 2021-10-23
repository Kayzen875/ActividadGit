using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniEnemy : EnemiesIA
{
    public Transform target;

    private bool co = true;
    private float dist;

    private void Start()
    {
        movement();
    }
    public override void movement()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * enemyData.speed);
    }

    private void Update()
    {
        if(transform.position.x < -125)
        {
            this.gameObject.SetActive(false);
        }

        dist = Vector3.Distance(target.position, transform.position);

        if(dist < 20 && co == true)
        {
            StartCoroutine(EnemyShoot());
            co = false;
        }
    }

    IEnumerator EnemyShoot()
    {
        float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;

        var b = Instantiate(enemyData.enemyBullets, transform.position, transform.rotation);
        //b.transform.Rotate(new Vector3(0, 0, 1), angle);
        b.GetComponent<Rigidbody2D>().AddForce(Vector2.up * enemyData.projectileSpeed);

        yield return new WaitForSeconds(1.0f);
    }
}
