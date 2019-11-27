using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update


    public void trocaPause(bool pause)
    {
        if (pause)
        {
            anim.SetBool("pausar", true);
            Time.timeScale = 0;
        }
    }
    public void mudaTempo()
    {
        anim.SetBool("pausar", false);
        Time.timeScale = 1;  
    }

}
