using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    [SerializeField] private GameObject target;
    [SerializeField] private float attackDistance;
    [SerializeField] private float attackInterval;
    [SerializeField] private GameObject bullet;
    private Vector2 firePosition;
    private float nextAttack;

	// Use this for initialization
	void Start () {
        nextAttack = Time.time + attackInterval;
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null)
            return;

        if((target.transform.position.x - transform.position.x) < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }


        if (Time.time >= nextAttack)
        {
            if((target.transform.position - transform.position).magnitude <= attackDistance)
                Attack();

        }
	}

    void Attack()
    {
        if(transform.localScale.x > 0)
        {
            firePosition = transform.position + Vector3.right * 0.5f;
        }
        else
        {
            firePosition = transform.position + Vector3.left * 0.5f;
        }

        GameObject bulletInstance = Instantiate(bullet, firePosition, transform.rotation);
        Bullet bulletScript = bulletInstance.GetComponent<Bullet>();
        bulletScript.SetTarget(target);

        nextAttack = Time.time + attackInterval;
    }
}
