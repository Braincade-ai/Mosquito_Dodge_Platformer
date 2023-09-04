using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Vector3 pos;
    public float tempo;
    public float tempocria;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        tempo -= Time.deltaTime;

        if (tempo < 1)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "jogador")
        {
            ScoreDisplay.pontos += 5;
            Destroy(this.gameObject);

        }
    }
}
