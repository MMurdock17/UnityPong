using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : NetworkedObject, ICollidable
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

    public override void Initialize()
    {

    }

    public override int GetNetworkId()
    {
        return -1;
    }


    public void OnHit(Collision2D collision) 
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 normal = collision.contacts[0].normal;

        Vector2 newVelocity = Vector2.Reflect(rb.velocity, normal);

        rb.velocity = newVelocity;
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {

        ICollidable collidable = collision.gameObject.GetComponent<ICollidable>();

        if (collidable != null)
        {
            collidable.OnHit(collision);
        }

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
