using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void iniciarJogo()
    {
        SceneManager.LoadScene("fase1");
    }

    public void encerrarJogo()
    {
        Application.Quit();
    }



}
