using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoPainel : MonoBehaviour
{

    public int botao;
    public GameObject Botao;
    SpriteRenderer Sr;

    private void Start()
    {
        if(Botao != null)
            Sr = Botao.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (Sr != null && !Sr.enabled)
        {
            Sr.enabled = true;
            if (botao < 11)
            {
                Senha.IncrementToPassword(botao.ToString());
            }
        }

        if (botao == 11)
            Senha.Clear();
        else if (botao == 12)
        {
            if (Senha.IsRight())
            {
                Debug.Log("Acertou");
                //trocar de Tela
                Application.LoadLevel("passoufase1");

            }
        }

    }
    private void OnMouseUp()
    {
        if (Sr != null && Sr.enabled)
        {
            Sr.enabled = false;

        }
    }
}
