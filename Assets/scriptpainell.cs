using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptpainell : MonoBehaviour
{

    Camera camera;
    Mouse script;
    public Painel pnl;
    public Transform fundo;
    Transform painelClone;

    private void Start()
    {
        camera = Camera.main;
        script = camera.GetComponent<Mouse>();
    }

    private void OnMouseDown()
    {
        pnl.bx.enabled = true;
        script.frezzed = false;
        fundo.position = new Vector3(fundo.position.x, fundo.position.y, 0);
        camera.orthographicSize += 4;
        Destroy(gameObject);
    }
}
