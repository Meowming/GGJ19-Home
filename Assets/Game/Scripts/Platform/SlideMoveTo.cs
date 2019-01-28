using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class SlideMoveTo : MonoBehaviour {
    public float time = 1f;
    public float targetZ = 3f;
    public Transform player;

    private float deltaSpeed;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            
            player = collision.transform;
            deltaSpeed = (player.position.z - targetZ) / time;
            StartCoroutine("MoveToPosition");
        }
    }

    IEnumerator MoveToPosition()
    {
        while (Mathf.Abs(player.position.z - targetZ) > 0.1f)
        {
            //print(Mathf.Abs(player.position.z - targetZ));
                player.position -= Vector3.forward * deltaSpeed * Time.deltaTime;
            yield return null;
        }
        yield return null;
    }
}
