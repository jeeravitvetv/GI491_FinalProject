using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;
    public float speed;
    public Transform explosion;
    public bool hitLastBar;
    private new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (hitLastBar == true)
        {
            Destroy(this.gameObject);
            return;
        }
        
        if(!inPlay)
        {
            transform.position = paddle.position;
        }

        if(Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bottom"))
        {
            //Debug.Log("Ball hit the bottom of the screen");
            rb.velocity = Vector2.zero;
            inPlay = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("brick"))
        {
            BrickScript brickScript = other.gameObject.GetComponent<BrickScript>();

            if (brickScript.hitsToBreak > 1)
            {
                brickScript.BreakBrick();
            }
            else
            {
                Transform newExplosion = Instantiate(explosion, other.transform.position, other.transform.rotation);
                Destroy(newExplosion.gameObject, 2.5f);

                Destroy(other.gameObject);
            }
            audio.Play();
        }
        else if (other.transform.CompareTag("lastbar"))
        {
            LastBar();
        }
    }

    void LastBar()
    {
        hitLastBar = true;
    }
}
