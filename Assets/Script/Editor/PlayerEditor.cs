using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEditor : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("x") || Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("historia");
        }
    }

    public void ToScene()
    {
        SceneManager.LoadScene("historia");
    }
}
