using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnCollisionEnter2D(Collision2D collision) {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(-rb.velocity.y, -rb.velocity.x);
    }

}
