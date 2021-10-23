using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySystem : MonoBehaviour
{
    void OnEnable()
    {
        GetComponent<HealthSystem>().Death += destruction;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().Death -= destruction;
        
    }

    void destruction()
    {
        Destroy(this.gameObject);
    }
}

//TryGetComponent

