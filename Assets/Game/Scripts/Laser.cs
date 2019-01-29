using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    [SerializeField] private float distance;
    [SerializeField] private Transform firePosition;
    [SerializeField] private GameObject laserBeans;

    [SerializeField] private float fireInterval;
    [SerializeField] private float fireTime;
    [SerializeField] private float startTime;
    private float nextFire;
    private float fireEnd;
    private GameObject laserBeanIns;

	// Use this for initialization
	void Start () {
        nextFire = Time.time + startTime;

    }
	
	// Update is called once per frame
	void Update () {

        if (Time.time >= nextFire)
        {
            Fire();
        }
        
        if(Time.time >=fireEnd)
        {
            FireEnd();
        }
	}

    void Fire()
    {
        laserBeanIns = Instantiate(laserBeans, firePosition.position, transform.rotation);

        laserBeanIns.transform.localScale = new Vector2(distance / 4, 1);
        fireEnd = Time.time + fireTime;
        nextFire = Time.time + fireInterval+ fireTime;
    }

    void FireEnd()
    {
        Destroy(laserBeanIns);
        fireEnd = Time.time + fireInterval + fireTime;
        nextFire = Time.time + fireInterval;
    }
}
