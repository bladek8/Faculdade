﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadroescondido : MonoBehaviour {

    public Transform quadro;
    public Transform fundo;
    public GameObject camera;
    public BoxCollider2D boxCollider2DFundo;
    Mouse script;

    private void OnMouseDown()
    {
        script = camera.GetComponent<Mouse>();
        script.frezzed = true;
        Vector3 cameraPosition = Camera.main.transform.position;
        Instantiate(quadro, new Vector3(cameraPosition.x, cameraPosition.y, -9), Quaternion.identity);
        fundo.position = new Vector3(fundo.position.x, fundo.position.y, -3);
    }
}
