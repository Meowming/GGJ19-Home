using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creatobj : MonoBehaviour {
    public GameObject pausePlayer;
    private bool nomore = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)&& nomore ==false)
        {

            Instantiate(pausePlayer, Vector2.zero,Quaternion.identity);
            nomore = true;
        }
    }
}
