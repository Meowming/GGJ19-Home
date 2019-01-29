using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private GameObject target;
    private Rigidbody2D rgbd2d;
    [SerializeField] private bool guided;
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float lifeTime = 5f;
    [SerializeField] private bool destroyOnCollide = true;
    private Vector2 currentDirection;
    private Vector2 direction;

    // Use this for initialization
    void Start () {
        lifeTime += Time.time;

        rgbd2d = GetComponent<Rigidbody2D>();
        if (target != null)
        {
            currentDirection = (target.transform.position - transform.position).normalized;

            if(guided)
            {
                float angle = Vector2.SignedAngle(currentDirection, Vector2.right);
                transform.Rotate(0f, 0f, -angle);
            }


            Debug.Log(currentDirection.magnitude);

            rgbd2d.velocity = currentDirection * speed * (1/ currentDirection.magnitude);
        }

        
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > lifeTime)
            Destroy(gameObject);

		if(guided && target != null)
        {
            direction = (target.transform.position - transform.position).normalized;

            float angle = Vector2.SignedAngle(currentDirection, direction);

                float sin = Mathf.Sin(rotateSpeed * Mathf.Sign(angle) * Mathf.Deg2Rad * Time.deltaTime);
                float cos = Mathf.Cos(rotateSpeed * Mathf.Sign(angle)*  Mathf.Deg2Rad * Time.deltaTime);

                float tx = currentDirection.x;
                float ty = currentDirection.y;

                currentDirection = new Vector2((cos * tx) - (sin * ty), (sin * tx) + (cos * ty));


            transform.Rotate(0f, 0f, rotateSpeed * Mathf.Sign(angle) * Time.deltaTime);
            rgbd2d.velocity = currentDirection * speed;
        }
	}

    public void SetTarget(GameObject Target)
    {
        target = Target;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Destroy(gameObject);
    }
}
