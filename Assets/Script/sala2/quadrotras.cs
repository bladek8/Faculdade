using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadrotras : MonoBehaviour {

    public Transform quadrofrente;
    public GameObject camera;
    Mouse script;

    private void Start()
    {
        script = camera.GetComponent<Mouse>();
    }

    private void OnMouseDown()
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        Instantiate(quadrofrente, new Vector3(cameraPosition.x, cameraPosition.y, -9), Quaternion.identity);
        //script.frezzed = false;
        //fundo.position = new Vector3(fundo.position.x, fundo.position.y, 0);
        //Destroy(gameObject);
    }
}
