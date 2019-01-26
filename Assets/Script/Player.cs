﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField] protected float speed = 5;
	[SerializeField] protected float jumpForce = 7.5f;
	private Rigidbody m_rigidbody;
	private Collider m_collider;
	private int score = 0;
	private bool isGrounded = false;

	// Use this for initialization
	void Start () {
		m_rigidbody = this.GetComponent<Rigidbody>();
		m_collider = this.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		Move();

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			Jump();
		}
			
	}

	void Jump()
	{
		//m_rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
		isGrounded = false;
		m_rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);  // Vector2.up is a short-hand notiation for new Vector2(0, 1)
	}

	void Move()
	{
		float movementModifier = Input.GetAxis("Horizontal"); // GetAxisRaw if you don't want a gradual change

		// We can move using transform.Translate
		//this.transform.Translate(new Vector2(movementModifier * speed * Time.deltaTime, 0));

		// But because we have a Rigidbody, we should adhere to Physics and set the Rigidbody's velocity instead
		Vector2 currentVelocity = m_rigidbody.velocity;
		m_rigidbody.velocity = new Vector2(movementModifier * speed, currentVelocity.y);
	}

	// Get's called on the exact frame that we touch a trigger
	void OnTriggerEnter2D(Collider2D collider)
	{
		// If we collide with something that's tagged as a Coin: Destroy it, increase our score, and log our new score to the console
		if (collider.CompareTag("Coin"))    // CompareTag is more efficient than doing collider.tag == "Coin"
		{
			Destroy(collider.gameObject);
			score++;
			Debug.Log(score);
		}
	}

	// Gets called on every frame that we continue to touch a trigger
	void OnTriggerStay2D(Collider2D collider) { }

	// Gets called on the exact frame that we stop touching a trigger
	void OnTriggerExit2D(Collider2D collider) { }

	// Gets called on the exact frame that we first physically touch a solid collider
	void OnCollisionEnter2D(Collision2D collision) { }

	// Gets called on every frame that we continue to physically touch a solid collider
	void OnCollisionStay2D(Collision2D collision)
	{
		// As long as we're touching something that's tagged as ground, check to see if our feet are touching it
		if (collision.collider.CompareTag("Ground"))
		{
			// We'll use a downward raycast to ensure we only set isGrounded to true if our feet touch something tagged ground
			//  This'll avoid complications where we say isGrounded = true if we collide with something tagged ground from the side or below
			Vector2 feetPosition = new Vector2(this.transform.position.x, m_collider.bounds.min.y); // bounds.min.y returns the position of the lowest point on the collider
			RaycastHit2D hitInfo = Physics2D.Raycast(feetPosition, Vector2.down, 0.1f); // We'll shoot a very short (0.1f units) raycast downward
			Debug.DrawRay(feetPosition, Vector2.down * 0.1f, Color.green);  // Draw a short line to visualize the ray as well
			if (hitInfo && hitInfo.collider.CompareTag("Ground"))   // If we hit something, and it's tagged as ground, we can finally set isGrounded = true
			{
				isGrounded = true;
			}
		}
	}

	// Gets called on the exact frame that we stop physically touching a solid collider
	void OnCollisionExit2D(Collision2D collision)
	{
		// Once we're no longer touching something that's tagged as gorund, set our isGrounded state to false
		if (collision.collider.CompareTag("Ground"))
		{
			isGrounded = false;
		}
	}
}
