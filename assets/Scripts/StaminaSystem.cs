using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StaminaSystem : MonoBehaviour
{
    public int MaxFuel;
    public int CurrentFuel;

    public event Action StaminaConsumption = delegate { };


}
