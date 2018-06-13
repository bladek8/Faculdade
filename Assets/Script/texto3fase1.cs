using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texto3fase1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool espaco = Input.GetKeyDown(KeyCode.Space);
        if (espaco)
            Application.LoadLevel("SampleScene");
    }
}
