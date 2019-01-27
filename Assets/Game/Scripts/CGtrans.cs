using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGtrans : MonoBehaviour
{
    public GameObject pausePlayer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pausePlayer.SetActive(true);
        }
    }
}