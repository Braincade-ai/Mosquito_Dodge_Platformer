using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public static int pontos;
    public Text pontoTxt;

    void Start()
    {
        pontos = 0;

    }

    void Update()
    {
        pontoTxt.text = pontos.ToString();

    }
}
