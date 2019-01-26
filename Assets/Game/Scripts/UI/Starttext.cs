using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starttext : MonoBehaviour {

    // Use this for initialization
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Application.LoadLevel("Tutorial");
        }


    }
}
