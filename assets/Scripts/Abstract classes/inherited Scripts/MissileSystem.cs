using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSystem : ShootingSystem
{
    public override void Shoot()
    {
        var shot = Instantiate(shootingdata.projectile, shootPoint.position, shootPoint.rotation);
        shot.GetComponent<TrackSystem>().Tracking();
    }
}
