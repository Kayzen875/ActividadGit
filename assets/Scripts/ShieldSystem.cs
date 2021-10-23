using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSystem : ShootingSystem
{
    public override void Shoot()
    {
        var shieldshoot = Instantiate(shootingdata.projectile, shootPoint.position, shootPoint.rotation);
    }
}
