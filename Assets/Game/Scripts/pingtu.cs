﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingtu : MonoBehaviour {
    //private Collider2D m_collider;
    private int rightPosition = 2;
    [SerializeField] public GameObject solutionPrefab;
    [SerializeField] public float sol_x;
    [SerializeField] public float sol_y;
    [SerializeField] public GameObject s1Prefab;
    [SerializeField] public GameObject s2Prefab;
    [SerializeField] public GameObject s3Prefab;
    [SerializeField] public GameObject s4Prefab;
    [SerializeField] public GameObject s5Prefab;
    [SerializeField] public GameObject s6Prefab;
    [SerializeField] public GameObject s7Prefab;
    [SerializeField] public GameObject s8Prefab;
    [SerializeField] public GameObject s9Prefab;
    [SerializeField] public GameObject s10Prefab;
    [SerializeField] public GameObject s11Prefab;
    [SerializeField] public GameObject s12Prefab;
    [SerializeField] public GameObject s13Prefab;
    [SerializeField] public GameObject s14Prefab;
    private Rotate_4 s1PrefabRotate;
    private Rotate_4 s2PrefabRotate;
    private Rotate_4 s3PrefabRotate;
    private Rotate_4 s4PrefabRotate;
    private Rotate_4 s5PrefabRotate;
    private Rotate_4 s6PrefabRotate;
    private Rotate_4 s7PrefabRotate;
    private Rotate_4 s8PrefabRotate;
    private Rotate_4 s9PrefabRotate;
    private Rotate_4 s10PrefabRotate;
    private Rotate_4 s11PrefabRotate;
    private Rotate_4 s12PrefabRotate;
    private Rotate_4 s13PrefabRotate;
    private Rotate_4 s14PrefabRotate;
    private bool isMatch = false;
    private bool print = false;


    // Use this for initialization
    void Start () {
        s1PrefabRotate = s1Prefab.GetComponent<Rotate_4>();
        s2PrefabRotate = s2Prefab.GetComponent<Rotate_4>();
        s3PrefabRotate = s3Prefab.GetComponent<Rotate_4>();
        s4PrefabRotate = s4Prefab.GetComponent<Rotate_4>();
        s5PrefabRotate = s5Prefab.GetComponent<Rotate_4>();
        s6PrefabRotate = s6Prefab.GetComponent<Rotate_4>();
        s7PrefabRotate = s7Prefab.GetComponent<Rotate_4>();
        s8PrefabRotate = s8Prefab.GetComponent<Rotate_4>();
        s9PrefabRotate = s9Prefab.GetComponent<Rotate_4>();
        s10PrefabRotate = s10Prefab.GetComponent<Rotate_4>();
        s11PrefabRotate = s11Prefab.GetComponent<Rotate_4>();
        s12PrefabRotate = s12Prefab.GetComponent<Rotate_4>();
        s13PrefabRotate = s13Prefab.GetComponent<Rotate_4>();
        s14PrefabRotate = s14Prefab.GetComponent<Rotate_4>();
       // m_collider = this.GetComponent<Collider2D>();

    }
	
	// Update is called once per frame
	void Update () {
        checkMatch();
        if (isMatch && !print)
        {
            Vector3 position = new Vector3(sol_x, sol_y, 0);
            Instantiate(solutionPrefab, position, Quaternion.identity);
            print = true;
        }
    }

    void checkMatch()
    {
            if (rightPosition == s1PrefabRotate.getPosition()
                && rightPosition == s2PrefabRotate.getPosition()
                && rightPosition == s3PrefabRotate.getPosition()
                && rightPosition == s4PrefabRotate.getPosition()
                && rightPosition == s5PrefabRotate.getPosition()
                && rightPosition == s6PrefabRotate.getPosition()
                && rightPosition == s7PrefabRotate.getPosition()
                && rightPosition == s8PrefabRotate.getPosition()
                && rightPosition == s9PrefabRotate.getPosition()
                && rightPosition == s10PrefabRotate.getPosition()
                && rightPosition == s11PrefabRotate.getPosition()
                && rightPosition == s12PrefabRotate.getPosition()
                && rightPosition == s13PrefabRotate.getPosition()
                && rightPosition == s14PrefabRotate.getPosition())
            {
                isMatch = true;
            }
        
    }
}
