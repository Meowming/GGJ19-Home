using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit : MonoBehaviour {
    public List<Vector3> nodes = new List<Vector3>();
    public Circuit next;
    public Circuit previous;
    public int cnt = 0;

    //pri
    public bool isReversed;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnDrawGizmos()
    {


        while (cnt < nodes.Count - 1)
        { 
            Gizmos.color = Color.red;
            Gizmos.DrawLine(nodes[cnt], nodes[cnt + 1]);
            cnt++;
        }
        cnt = 0;
    }
}
