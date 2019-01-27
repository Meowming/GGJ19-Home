using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour {
    public static bool Gamep = false;
    public GameObject pausePlayer;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Gamep)
            {
                Resum();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resum()
    {
        pausePlayer.SetActive(false);
        Time.timeScale = 1f;
        Gamep = false;
    }
    void Pause()
    {
        pausePlayer.SetActive(true);
        Time.timeScale = 0f;
        Gamep = true;
    }
   
}
