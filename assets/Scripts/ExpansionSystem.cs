using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpansionSystem : MonoBehaviour
{
    public Vector3 augment;

    private void FixedUpdate()
    {
        transform.localScale += augment * Time.deltaTime;
    }
}
