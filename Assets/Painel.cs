using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painel : MonoBehaviour
{

    Camera camera;
    //public Transform painel;
    Mouse script;
    public Transform fundo;
    bool isClicked = false;

    private void Start()
    {
        camera = Camera.main;
        script = camera.GetComponent<Mouse>();
    }

    private void OnMouseDown()
    {
        if (!isClicked)
        {
            script.frezzed = true;
            isClicked = true;
            //Instantiate(painel, new Vector3(camera.x, camera.y, -9), Quaternion.identity);
            fundo.position = new Vector3(fundo.position.x, fundo.position.y, -3);
            camera.orthographicSize -= 4;
            camera.transform.position = new Vector3(camera.transform.position.x, 1.2f, camera.transform.position.z);
        }
        else
        {
            script.frezzed = false;
            isClicked = false;
            fundo.position = new Vector3(fundo.position.x, fundo.position.y, 0);
            camera.orthographicSize += 4;
        }
    }
}
