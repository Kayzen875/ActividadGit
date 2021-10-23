using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text text;
    public Text scoreText;
    public Slider HpSlider;
    public Slider StaminaSlider;

    public int points = 0;

    void OnEnable()
    {
        MainPlayer.SetHealth += UiUpdate;
        ScoreSystem.SetScore += ScoreUpdate;
        //PRUEBAS FUEL
        MainPlayer.SetStamina += StaminaUpdate;
    }

    void OnDisable()
    {
        MainPlayer.SetHealth -= UiUpdate;
        ScoreSystem.SetScore -= ScoreUpdate;
        //PRUEBAS FUEL
        MainPlayer.SetStamina -= StaminaUpdate;
    }

    void UiUpdate(int HealthPoints)
    {
        text.text = "Health = " + HealthPoints;
        HpSlider.value = HealthPoints;
    }

    void ScoreUpdate(int ScorePoints)
    {
        points = points + ScorePoints;
        scoreText.text = "Score = " + points;
    }

    // DE AQUI ABAJO PRUEBAS
    void StaminaUpdate()
    {
        StartCoroutine("CoFuelDown");
    }

    IEnumerator CoFuelDown()
    {
        StaminaSlider.value -= 10;
        yield return new WaitForSeconds(1.0f);      
    }
}
