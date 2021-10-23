using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainPlayer : MonoBehaviour
{
    private int hp;
    private int stamina;

    public static event Action<int> SetHealth = delegate { };
    //PRUEBAS FUEL
    public static event Action SetStamina = delegate { };

    void OnEnable()
    {
        GetComponent<HealthSystem>().CurrentHp += MyHealthPoints;
        //PRUEBAS FUEL
        GetComponent<InputSystemKeyboard>().StaminaConsumption += MyStaminaPoints;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().CurrentHp -= MyHealthPoints;
        //PRUEBAS FUEL
        GetComponent<InputSystemKeyboard>().StaminaConsumption -= MyStaminaPoints;
    }

    private void MyHealthPoints()
    {
        hp = GetComponent<HealthSystem>().MyCurrentHp();
        SetHealth(hp);
    }

    //PRUEBAS FUEL
    private void MyStaminaPoints()
    {
        SetStamina();
    }
}
