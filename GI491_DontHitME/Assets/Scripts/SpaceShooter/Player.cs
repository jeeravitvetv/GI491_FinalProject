using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	//controls how fast the player moves
	public float moveSpeed; //default speed, can change if you want.

	public Rigidbody2D player;
	public GameManager gm;

	// Use this for initialization
	void Start()
	{
		player = this.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		//this.transform.Translate(Input.GetAxis("Horizontal"),0,0); //using transform ignores physics!!!

		MovePlayer();

	}
	//this function allows for the player to move
	public void MovePlayer()
	{
        //movement through physics. Makes things like hitting walls much easier to deal with!
        //player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            Destroy(other.gameObject);
            gm.UpdateLives(-1);
        }
        else if (other.CompareTag("SATK"))
        {
            gm.UpdateLives(-1);
        }
    }
}