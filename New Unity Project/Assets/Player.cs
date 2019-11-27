using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float velocidade;
    float rotaçao;
    float correr;
    public GameObject Pause;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 0;
        rotaçao = 0;
        correr = 0;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.timeScale == 1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                velocidade = 0.2f;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                velocidade = 0;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                velocidade = -0.2f;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                velocidade = 0;
            }
            transform.Translate(velocidade, 0, 0);

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rotaçao = 2f;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                rotaçao = 0;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rotaçao = -2f;
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                rotaçao = 0;
            }
            transform.Rotate(0, rotaçao, 0);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                correr = 0.6f;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                correr = 0;
            }
            transform.Translate(correr, 0, 0);
        }

        //tela de pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Pause.SetActive(true);
        }



    }

    public void SaiPause()
    {
        Time.timeScale = 1;
        Pause.SetActive(false);

    }



}
