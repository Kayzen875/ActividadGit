using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{
    public float hor { get; private set; } //get sirve para poder leer la propiedad
    public float ver { get; private set; } //set sirve para poder asignar la propiedad

    public event Action OnFire = delegate { }; //OnFire es el nombre de la variable
    //Esto es la creacion de un evento que detecta cuando pulsas espacio
    public event Action Move = delegate { };

    //PRUEBAS FUEL
    public event Action StaminaConsumption = delegate { };

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Fire1"))
        {
            OnFire();
        }

        if (ver == 1)
        {
            Move();
        }
        //PRUEBAS FUEL
        if (ver == 1 || ver == -1)
        {
            StaminaConsumption();
        }

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            OnDoubleFire();
        }*/
    }
}
