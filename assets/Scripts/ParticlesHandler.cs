using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesHandler : MonoBehaviour
{
    /*[SerializeField]
    public ParticleSystem explosion;*/

    [SerializeField]
    public ParticleSystem motor;

    [SerializeField]
    public ParticleSystem explosion;

    [SerializeField]
    public Transform motorPlace;

    private ParticleSystem prueba;

    private InputSystemKeyboard inputSystem;

    void Awake() // Se ejecuta cuando el objeto se activa.
    {
        inputSystem = GetComponent<InputSystemKeyboard>();
        prueba = Instantiate(motor, motorPlace.position, motorPlace.rotation, motorPlace.parent);
        var emission = prueba.emission;
        emission.enabled = false;
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().Death += Explosion;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().Death -= Explosion;

    }

    void Update()
    {
        if(inputSystem.ver > 0)
        {      
            var emission = prueba.emission;
            emission.enabled = true;
        }
        else if(inputSystem.ver == 0)
        {
            var emission = prueba.emission;
            emission.enabled = false;
        }
    }

    private void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }


}
