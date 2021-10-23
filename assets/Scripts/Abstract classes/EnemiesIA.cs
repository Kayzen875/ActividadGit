using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemiesIA : MonoBehaviour
{
    public EnemiesData enemyData;

    public abstract void movement();
}
