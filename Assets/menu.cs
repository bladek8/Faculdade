using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {
    public void start()
    {
        //Debug.Log("Mudou a cena");
        Application.LoadLevel("textofase1");
    }

    public void sair()
    {
        //Debug.Log("Fechou o jogo");
        Application.Quit();
    }
}
