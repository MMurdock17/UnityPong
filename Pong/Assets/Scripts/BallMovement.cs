using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    private float speed;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(5f, 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

    }

    public float GetSpeed() 
    {
        return speed;
    }

    public void SetSpeed(float newSpeed) 
    {
        speed = newSpeed;
    }

    public Vector2 GetDirection() 
    {
        return direction;
    }

    public void SetDirection(Vector2 newDirection) 
    {
        direction = newDirection.normalized;
    }

}
