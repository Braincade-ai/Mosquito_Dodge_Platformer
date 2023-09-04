using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D mosquitoRB;
    public Vector3 posicao;
    public GameObject mosquitoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        mosquitoRB = GetComponent<Rigidbody2D>();
        posicao = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "destroi")
        {
            Instantiate(mosquitoPrefab, posicao, transform.localRotation);
            ScoreDisplay.pontos += 1;
            Destroy(this.gameObject);

        }

    }

    //void OnBecameInvisible()
    //{
    //    Instantiate(mosquitoPrefab, posicao, transform.localRotation);
    //    ponto.pontos += 1;
    //    Destroy(this.gameObject);
                
    //}
}
