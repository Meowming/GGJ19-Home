using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	private Collider2D m_collider;
	private int currentPosition = 1;
    Vector3 Pos;
    Vector3 mousePosInWorld;

    // Use this for initialization
    void Start () {
		m_collider = this.GetComponent<Collider2D>();
        Pos = Camera.main.WorldToScreenPoint(transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.mousePosition);
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Pos.z);
        mousePosInWorld = Camera.main.ScreenToWorldPoint(mousePos);


        if (Input.GetKeyDown(KeyCode.Mouse0) &&
            m_collider.bounds.min.y <= mousePosInWorld.y && mousePosInWorld.y <= m_collider.bounds.max.y && 
            m_collider.bounds.min.x <= mousePosInWorld.x && mousePosInWorld.x <= m_collider.bounds.max.x)
		{
			this.transform.eulerAngles = new Vector3 (0, 0, 45 * currentPosition);
			currentPosition++;
		}
	}
	public int getPosition()
	{
		return currentPosition % 8;
	}
}
