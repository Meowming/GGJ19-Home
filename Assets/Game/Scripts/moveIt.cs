using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveIt : MonoBehaviour {
    [SerializeField] public GameObject trickPrefab;
    private trick Connection;
    private bool isConnected = false;
    private float pos_x;
    // Use this for initialization
    void Start () {
        Connection = trickPrefab.GetComponent<trick>();
        pos_x = this.transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {
        isConnected = Connection.Get_upCheck();
        if (isConnected && this.transform.position.x < pos_x + 3)
        {
            this.transform.Translate(new Vector2(2 * Time.deltaTime,0), 0);
        }
    }
}
