using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PaddleController : NetworkedObject
{

    protected float speed = 5f;
    protected Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected abstract float GetMovementInput();

}
