using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    [SerializeField] private float xDirection;
    [SerializeField] private float yDirection;
    [SerializeField] private float distance;
    private Vector2 direction;

	// Use this for initialization
	void Start () {
        direction = new Vector2(xDirection, yDirection);
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D laserBean = Physics2D.Raycast(transform.position, direction, distance);

        if(laserBean.collider.CompareTag("player"))
        {

        }
	}
}
