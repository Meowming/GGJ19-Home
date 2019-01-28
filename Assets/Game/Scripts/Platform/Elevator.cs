using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : Entity {
    public bool isRunning = false;
    //  public bool isLoop = false;
    public float speed = 5f;
    public Vector3 direction = Vector3.up;
    public float moveDistance = 100f;


    private float runTime = 0f;
    public bool isReversed = false;
	// Use this for initialization
	void Start () {
        runTime = moveDistance / speed;
        isReversed = !isReversed;
    }
	
	// Update is called once per frame
	void Update () {
        if (runTime >= 0 && isRunning)
        {
            if (isReversed)
                transform.position -= direction * speed * Time.deltaTime;
            else
                transform.position += direction * speed * Time.deltaTime;
            runTime -= Time.deltaTime;
        }
        else if (runTime <= 0f)
        {
            isRunning = false;
        }
	}
    public override void TriggerStart()
    {
        if (isRunning)
            return;
        isReversed = !isReversed;
        isRunning = true;
        runTime = moveDistance / speed;
    }
    public override void TriggerEnd()
    {
        //isRunning = false;
    }
}
