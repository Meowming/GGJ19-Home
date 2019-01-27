using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trick : MonoBehaviour {
    [SerializeField] public GameObject OctPrefab;
    [SerializeField] public GameObject BasePrefab;
    private Rotate_4 OctPrefabRotate;
    private power_check Check;
    private int rightPos_up;
    private int rightPos_low;
    private bool isConnected_low_check = false;
    private bool up = false;
    private bool low = false;
    private int OctPos = 4;


    // Use this for initialization
    void Start() {
        OctPrefabRotate = OctPrefab.GetComponent<Rotate_4>();
        Check = BasePrefab.GetComponent<power_check>();
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(OctPrefabRotate.getPosition());
        OctPrefabRotate.getPosition();
        //Debug.Log(OctPrefabRotate.getPosition());
        if (OctPrefabRotate.getPosition() == 3)
        {
            up = true;
        }
        if (Check.Connected() && (OctPrefabRotate.getPosition() == 2 || OctPrefabRotate.getPosition() == 0))
        {
            low = true;
        }
    }

    public bool Get_upCheck()
    {
        return up;
    }

    public bool Get_lowCheck() {
        return low;
    }
}
