﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    public List<Entity> targets = new List<Entity>();
    public bool isPlayerOnly;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPlayerOnly)
        {
            if (collision.tag == "Player")
                foreach (Entity target in targets)
                {
                    target.TriggerStart();
                }
        }
        else
            foreach (Entity target in targets)
            {
                target.TriggerStart();
            }
    }
}
