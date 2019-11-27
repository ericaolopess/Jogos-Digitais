using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    public Vector2 forcaPulo = new Vector2(0, 300);
    public int MaxVelocidade = 5;
    public GameObject coletaveis;
    public Canvas canvas;
    public int points = 0;
    public int vida = 10;
    public Slider life;
    public Animator anim;
    public Canvas xpause;
    public GameObject particula;
    public GameObject particula2;

    void Start()
    {
        anim.SetBool("pausar", false);
   
    }

    // Update is called once per frame
    void Update()
    {
        canvas.gameObject.GetComponentInChildren<Text>().text = points.ToString();

        /*  switch (vida)
          {
              case 1:
                  Destroy
                      (canvas.gameObject.GetComponentInChildren<Sprite>().name = "life1");
                  break;

          }
          */


        //jump player
        if (Input.GetKeyUp("space") || Input.GetKeyUp("w"))
        {
            GetComponent<Rigidbody2D>().AddForce(forcaPulo);
            GetComponent<Animator>().SetBool("pulando", true);
            GetComponent<Animator>().SetBool("andando", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("pulando", false);

        }

        //player andar para direita e esquerda

        float movimento = Input.GetAxis("Horizontal");

        //movimento for negativo andar para esquerda
        //movimento for positivo andar para direita

        GetComponent<Rigidbody2D>().velocity = new Vector2(movimento * MaxVelocidade,
                                                           GetComponent<Rigidbody2D>().velocity.y);

 




        //alterar flip player
        if (movimento > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetBool("andando", true);
        }
        else if (movimento < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetBool("andando", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("andando", false);

        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {

            Time.timeScale = 0;
            xpause.gameObject.SetActive(true);
    
        }


        if (vida == 0)
        {
            SceneManager.LoadScene("GameOver");
        }




    }

    void OnTriggerEnter2D(Collider2D mata)
     {
        if(mata.gameObject.tag == "inimigo")
        {
            //Debug.LogError(mata.gameObject);
            Destroy(Instantiate(particula, mata.transform.position, 
                            mata.transform.rotation),0.6f);
            Destroy(mata.gameObject);
        }


     }




    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "coletavel")
        {
            
            Destroy(Instantiate(particula2, coll.transform.position, coll.transform.rotation), 0.6f);
            Destroy(coll.gameObject);
            points += 1;
        }

        if (coll.gameObject.tag == "inimigo")
        {
            
            vida -= 1;
            life.value = vida;



            
            // barradevida.value = hp;
        }

    }



    public void mudaTempo()
    {

        xpause.gameObject.SetActive(false);
        Time.timeScale = 1;
    }


}
