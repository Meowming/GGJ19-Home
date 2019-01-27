using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_check : MonoBehaviour {
    private bool isConnected = false;
    private bool a = true;
    private bool b = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isConnected)
        {
            //Debug.Log(isConnected);
            b = true;
        }

        //Debug.Log(b);
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.collider.tag == "Battery")
        {
            
            isConnected = true;
            //Debug.Log(isConnected);
        }
    }

    public bool Connected() {
        Debug.Log(b);
        //Debug.Log(isConnected);
        if (b)
        {
            Debug.Log(isConnected);
            return true;
        }
        
        return false;
    }
}
