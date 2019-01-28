using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightEffector : Entity {

    Light light;
    Color color;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        color = light.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void TriggerStart()
    {
        light.color = Color.yellow;
    }
    public override void TriggerEnd()
    {
        light.color = color;
    }
}
