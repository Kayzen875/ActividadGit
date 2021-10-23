using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreSystem : MonoBehaviour
{
    public int points;

    public static event Action<int> SetScore = delegate { };

    private void OnDestroy()
    {
        SetScore(points);
    }
}
