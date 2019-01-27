using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_down : MonoBehaviour { 
	private int[,] codes = new int[3,3]{ { 1, 2, 1 }, { 1, 5, 1 }, { 4, 2, 8 } };
	[SerializeField] public GameObject s1Prefab;
	[SerializeField] public GameObject s2Prefab;
	[SerializeField] public GameObject s3Prefab;
	[SerializeField] float speed;
	[SerializeField] float distant;
	private Rotate s1PrefabRotate;
	private Rotate s2PrefabRotate;
	private Rotate s3PrefabRotate;
	//private Collider2D m_collider;
   // private Rigidbody2D m_Rigidbody;
    private bool isMatch;
    private float final;


    // Use this for initialization
    void Start () {
		s1PrefabRotate = s1Prefab.GetComponent<Rotate> ();
		s2PrefabRotate = s2Prefab.GetComponent<Rotate> ();
		s3PrefabRotate = s3Prefab.GetComponent<Rotate> ();
		//m_collider = this.GetComponent<Collider2D>();
       // m_Rigidbody = this.GetComponent<Rigidbody2D>();
        final = this.transform.position.y - distant;
    }

	// Update is called once per frame
	void Update () {
        checkMatch ();
        if (isMatch && this.transform.position.y > final)
        {
            this.transform.Translate(new Vector2(0, -1 * speed * Time.deltaTime), 0);
        }
	}

	void checkMatch (){
		for (int i = 0; i < 3; i++) {
			if ((codes [i, 0] == s1PrefabRotate.getPosition () || 8 == codes [i, 0])
			    && (codes [i, 1] == s2PrefabRotate.getPosition () || 8 == codes [i, 1])
			    && (codes [i, 2] == s3PrefabRotate.getPosition () || 8 == codes [i, 2])) {
				isMatch = true;
			}
		}
	}
    
}
