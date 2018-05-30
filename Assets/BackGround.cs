using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    public GameObject camera;
    public BoxCollider2D boxCollider2D;
    Mouse script;
    private void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        script = camera.GetComponent<Mouse>();
    }

    private void OnMouseDown()
    {
        //if (script.frezzed && boxCollider2D.isTrigger)
        //{
        //    script.frezzed = true;
        //    boxCollider2D.isTrigger = false;
        //}
    }
}
