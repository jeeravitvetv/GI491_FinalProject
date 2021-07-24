using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
	public Rigidbody2D projectile;//reference to a rigidbody2d

	public float moveSpeed = 10.0f;

	// Use this for initialization
	void Start()
	{
		projectile = this.gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		projectile.velocity = new Vector2(0, 1) * moveSpeed;
	}

	//add some hit detecion
	void OnCollisionEnter2D(Collision2D col)
	{
		//when it hits the top of the screen
		if (col.transform.CompareTag("wall"))
		{
			Destroy(this.gameObject);
		}
		if (col.transform.CompareTag("t_object"))
		{
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		//when it hits an enemy...
		if (other.CompareTag("ball"))
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
	}
}
