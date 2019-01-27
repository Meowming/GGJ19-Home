using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class SlideMove : MonoBehaviour {
    public float factor = 1f;
    public bool isReversed = false;//when x+, z+ by default
    public float lastX = 0f;
    private BoxCollider2D zone;
	// Use this for initialization
	void Start () {
        zone = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            lastX = collision.transform.position.x;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            float offset = collision.transform.position.x - lastX;
            if(!isReversed)
                collision.transform.position += Vector3.forward * offset * factor;
            else
                collision.transform.position -= Vector3.forward * offset * factor;
            lastX = collision.transform.position.x;
        }
    }
}
