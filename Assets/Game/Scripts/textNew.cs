using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textNew : MonoBehaviour {
    public GameObject image1;
    // Use this for initialization
    void Start () {

        
}
	
	// Update is called once per frame
	void Update () {
        if (NPCBehavior.finished == true)
        {
            image1.SetActive(true);
            NPCBehavior.finished = false;
        }
	}
}
