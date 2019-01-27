using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitMover : MonoBehaviour {
    public Circuit current;
    public int cnt = 0;
    public float speed = 0.1f;
    public float distance = 0f;
    public float time = 0f;
    public Vector3 direction;

    private float nodeTime = 0f;
    
	// Use this for initialization
	void Start () {
        transform.position = current.nodes[0];
        if (current.nodes.Count < 1)
            return;
        changeNode(current.nodes[0], current.nodes[1]);

    }

    // Update is called once per frame
    void Update() {
        if (current)
        {
            nodeTime += Time.deltaTime;
            if (nodeTime <= time)
                transform.position += direction * speed * Time.deltaTime;
            else
            {
                cnt++;
                changeNode(current.nodes[cnt], current.nodes[cnt + 1]);
            }

        }
	}

    void changeNode(Vector3 start, Vector3 end)
    {
        transform.position = current.nodes[cnt];
        direction = end - start;
        distance = direction.magnitude;
        direction = direction.normalized;
        time = distance / speed;
        nodeTime = 0f;
    }
}
