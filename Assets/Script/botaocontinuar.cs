using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botaocontinuar : MonoBehaviour {

    private float velocidade, tempoanimbkp;
    private Text continuar;
    public float tempoanim;

    void Start()
    {
        continuar = GetComponent<Text>();
        tempoanimbkp = tempoanim;
    }

    // Update is called once per frame
    void Update () {
        //bool enter = Input.GetKeyDown(KeyCode.Return);

        tempoanim -= Time.deltaTime;
        if (tempoanim <= 0)
        {
            continuar.enabled = !continuar.enabled;
            tempoanim = tempoanimbkp;
        }
        //if (enter)
           //Application.LoadLevel("SampleScene");
    }
}
