using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleController : PaddleController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = Input.GetAxis("RightPaddle");

        transform.position += new Vector3(0, velocity * speed * Time.deltaTime, 0);
    }

    protected override float GetMovementInput() 
    {
        return Input.GetAxis("RightPaddle");
    }

}
