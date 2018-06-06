using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoPainel : MonoBehaviour
{

    public int botao;
    public GameObject Botao;
    SpriteRenderer Sr;
    public int[] senha = { 1, 6, 1, 2, 1, 2, 0, 1, 1, 5 };
    public int[] senhadigitada;

    private void Start()
    {
        Sr = Botao.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!Sr.enabled)
        {
            Sr.enabled = true;

        }
    }  
    private void OnMouseUp()
    {
        if (Sr.enabled)
        {
            Sr.enabled = false;

        }
    }
    public void SenhaCerta()//é essa aqui lucão
    {
        if(senhadigitada != senha)
        {

        }
    }
            //switch (botao)
            //{
            //    case 0:
            //        //Instantiate(Botao, new Vector3(0.1699f, -0.7659f, -9), Quaternion.identity);
            //        break;
            //    case 1:
            //        //Instantiate(Botao, new Vector3(-0.1444f, 0.2834f, -9), Quaternion.identity);
            //        break;
            //    case 2:
            //        //Instantiate(Botao, new Vector3(0.168f, 0.2835f, -9), Quaternion.identity);
            //        break;
            //    case 3:
            //        //Instantiate(Botao, new Vector3(0.4769f, 0.2844f, -9), Quaternion.identity);
            //        break;
            //    case 4:
            //        //Instantiate(Botao, new Vector3(-0.143f, -0.0854f, -9), Quaternion.identity);
            //        break;
            //    case 5:
            //        //Instantiate(Botao, new Vector3(0.1726f, -0.0849f, -9), Quaternion.identity);
            //        break;
            //    case 6:
            //        //Instantiate(Botao, new Vector3(0.472f, -0.084f, -9), Quaternion.identity);
            //        break;
            //    case 7:
            //        //Instantiate(Botao, new Vector3(-0.1313f, -0.434f, -9), Quaternion.identity);
            //        break;
            //    case 8:
            //        //Instantiate(Botao, new Vector3(0.173f, -0.4374f, -9), Quaternion.identity);
            //        break;
            //    case 9:
            //        //Instantiate(Botao, new Vector3(0.4831f, -0.4337f, -9), Quaternion.identity);
            //        break;
            //    case 10:
            //        //Instantiate(Botao, new Vector3(0, 0, -9), Quaternion.identity);
            //        break;
            //    case 11:
            //        //Instantiate(Botao, new Vector3(0, 0, -9), Quaternion.identity);
            //        break;
            //}
 }
