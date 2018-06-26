using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papel2 : MonoBehaviour {

    public Transform fundo;
    public GameObject camera;
    Mouse script;

    private void Start()
    {
        script = camera.GetComponent<Mouse>();
    }

    private void OnMouseDown()
    {
        script.frezzed = false;
        fundo.position = new Vector3(fundo.position.x, fundo.position.y, 0);
        Destroy(gameObject);
    }
}
