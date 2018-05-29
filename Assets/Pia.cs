using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pia : MonoBehaviour
{
    Transform papel;
    private void OnMouseDown()
    {
        Instantiate(papel, Camera.main.transform.position, Quaternion.identity);
    }
}
