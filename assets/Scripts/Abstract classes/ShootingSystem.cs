using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootingSystem : MonoBehaviour
{
    public ShootingSystemData shootingdata;

    public Transform shootPoint;
 
    //Al poner abstract no se llama al codigo
    public abstract void Shoot();
}
