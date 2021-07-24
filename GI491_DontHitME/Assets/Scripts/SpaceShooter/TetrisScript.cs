using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisScript : MonoBehaviour
{
    Collider2D tetris;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("tetris"))
        {
            tetris = GetComponent<Collider2D>();
            tetris.isTrigger = false;
        }
    }
}
