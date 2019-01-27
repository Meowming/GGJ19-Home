using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : Entity {
    public int index = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerStart()
    {
        SceneManager.LoadScene(index);
    }
    public override void TriggerEnd()
    {
        return;
    }
}
