using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEditor : MonoBehaviour
{
    private Rigidbody2D pneuRB;
    public Vector3 pos;
    public GameObject pneuPrefab;
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
