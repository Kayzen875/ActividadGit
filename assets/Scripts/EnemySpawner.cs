using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
    public Transform player;

    void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        var e = Instantiate(enemy, spawnPoints[Random.Range(0,8)].position, spawnPoints[0].rotation);
        e.GetComponent<OvniEnemy>().target = player;
        yield return new WaitForSeconds(10.0f);
        StartCoroutine(spawner());
    }
}
