using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text textofinal;
    void Start()
    {
        textofinal.text = ScoreDisplay.pontos.ToString();

    }
}
