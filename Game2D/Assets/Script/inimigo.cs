using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{

    public int MaxVelocidade = 5;
    float posInicial, posFinal, movimento, posAtual;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = GetComponent<Transform>().position.x;
        posFinal = (GetComponent<Transform>().position.x) + 10;
        posAtual = GetComponent<Transform>().position.x;

        print("posição inicial -->" + posInicial);
        print("posição final -->" + posFinal);
        movimento = 1;
    }

    // Update is called once per frame
    void Update()
    {
        posAtual = GetComponent<Transform>().position.x;

        GetComponent<Rigidbody2D>().velocity = 
                     new Vector2(movimento * MaxVelocidade,
                         GetComponent<Rigidbody2D>().velocity.y);

        if (posAtual >= posFinal)
        {

            movimento = -1f;
            GetComponent<SpriteRenderer>().flipX = false;
            print("posição aki final -->" + posAtual);
        }

        if (posAtual <= posInicial)
        {
            movimento = 1f;
            GetComponent<SpriteRenderer>().flipX = true;
            print("posição aki inicial -->" + posAtual);
        }

    }
}
