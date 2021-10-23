using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    public GameObject[] meteor;
    public Transform[] positions;


    void Start()
    {
        StartCoroutine(GenerateMeteor());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerateMeteor()
    {
        Instantiate(meteor[Random.Range(0,2)], positions[Random.Range(0,5)].position, Quaternion.identity);
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(GenerateMeteor());
    }
}
