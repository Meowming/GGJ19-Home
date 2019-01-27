using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private GameObject target;
    private Rigidbody2D rgbd2d;
    [SerializeField] private bool guided;
    [SerializeField] private float speed;

	// Use this for initialization
	void Start () {
        rgbd2d = GetComponent<Rigidbody2D>();
        Vector2 direction = (target.transform.position - transform.position).normalized;

        rgbd2d.velocity = direction * speed;
    }
	
	// Update is called once per frame
	void Update () {
		if(guided)
        {
            Vector2 direction = (target.transform.position - transform.position).normalized;

            rgbd2d.velocity = direction * speed;
        }
	}

    public void SetTarget(GameObject Target)
    {
        target = Target;
    }
}
