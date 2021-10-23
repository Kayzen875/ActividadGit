using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSystem : MonoBehaviour
{
    [SerializeField]
    private Text text;

    public static int score;

    private void Update()
    {
        text.text = "Health = " + score;
    }
}
