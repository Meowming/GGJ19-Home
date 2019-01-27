using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingCam : MonoBehaviour {
	private float speed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (new Vector2 (speed * Time.deltaTime, 0));
	}
}
