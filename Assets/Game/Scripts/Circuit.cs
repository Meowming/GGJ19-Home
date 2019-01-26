using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit : MonoBehaviour {
    public List<Vector3> nodes = new List<Vector3>();
    public int cnt = 0;
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
            print("sss");

            Gizmos.color = Color.red;
            Gizmos.DrawLine(nodes[cnt], nodes[cnt + 1]);
            cnt++;

        }
        cnt = 0;
    }
}
