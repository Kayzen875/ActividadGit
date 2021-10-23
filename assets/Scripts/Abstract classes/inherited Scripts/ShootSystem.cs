using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShootSystem : ShootingSystem
{
    /*ANTES public override void Shoot()
    {
        var shot = Instantiate(shootingdata.projectile, shootPoint.position, shootPoint.rotation);
        shot.GetComponent<Rigidbody2D>().AddForce(shootPoint.transform.up * shootingdata.fireForce);
    }*/

    //AHORA

    public override void Shoot()
    {
        GameObject shot = PoolingManager.Instance.GetPooledObject();
        if(shot != null)
        {
            shot.transform.position = shootPoint.position;
            shot.transform.rotation = shootPoint.rotation;
            shot.SetActive(true);
            shot.GetComponent<Rigidbody2D>().AddForce(transform.up * shootingdata.fireForce);
        }
    }
}
