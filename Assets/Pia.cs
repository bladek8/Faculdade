using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pia : MonoBehaviour
{
    public Transform papel;
    public Transform fundo;
    private void OnMouseDown()
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        Instantiate(papel, new Vector3(cameraPosition.x, cameraPosition.y, -9), Quaternion.identity);
        fundo.position = new Vector3(fundo.position.x, fundo.position.y, -3);
    }
}
