using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painel : MonoBehaviour
{

    Camera camera;
    public Transform painel;
    Mouse script;
    public Transform fundo;
    Transform painelClone;
    public BoxCollider2D bx;

    private void Start()
    {
        bx.GetComponent<BoxCollider2D>();
        camera = Camera.main;
        script = camera.GetComponent<Mouse>();
    }

    private void OnMouseDown()
    {
        bx.enabled = false;
        script.frezzed = true;
        painelClone = Instantiate(painel, new Vector3(-0.067f, 1.13f, -9), Quaternion.identity);
        fundo.position = new Vector3(fundo.position.x, fundo.position.y, -3);
        camera.orthographicSize -= 4;
        camera.transform.position = new Vector3(camera.transform.position.x, 1.2f, camera.transform.position.z);
    }
}
