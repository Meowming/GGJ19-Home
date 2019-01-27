using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : Entity {
    public bool isRunning = false;
    //public bool isLoop = false;
    public float speed = 5f;
    public Vector3 direction = Vector3.up;
    public float moveDistance = 100f;

    private float runTime = 0f;
	// Use this for initialization
	void Start () {
        runTime = moveDistance / speed;
	}
	
	// Update is called once per frame
	void Update () {
        if (runTime >= 0 && isRunning)
        {
            transform.position += direction * speed * Time.deltaTime;
            runTime -= Time.deltaTime;
        }
	}
    public override void TriggerStart()
    {
        isRunning = true;
    }
    public override void TriggerEnd()
    {
        isRunning = false;
    }
}
