using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EnemiesData")]
public class EnemiesData : ScriptableObject
{
    public GameObject enemyBullets;
    public int damage;
    public float speed;
    public float projectileSpeed;
    public int health;
}
