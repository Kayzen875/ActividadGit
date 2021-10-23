using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    private int MaxHealth;

    [SerializeField]
    private int CurrentHealth;

    public event Action Death = delegate { };

    public event Action CurrentHp = delegate { };

    void Start()
    {
        CurrentHealth = MaxHealth;
        CurrentHp();
    }

    public void Hitted(int damage)
    {
        CurrentHealth += -damage;

        if (TryGetComponent(out MainPlayer p))
        {
            CurrentHp();
        }

        if(CurrentHealth <= 0)
        {
            Death();
        }
    }

    public int MyCurrentHp()
    {
        return CurrentHealth;
    }

    public void RestoreHealth(int h)
    {
        if(CurrentHealth < 10)
        {
            CurrentHealth += h;

            if (TryGetComponent(out MainPlayer p))
            {
                CurrentHp();
            }
        }
    }
}
