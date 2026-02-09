using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleController : PaddleController, ICollidable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = Input.GetAxis("LeftPaddle");

        transform.position += new Vector3(0, velocity * speed * Time.deltaTime, 0);
    }

    public override void Initialize()
    {

    }

    public override int GetNetworkId()
    {
        return -1;
    }

    protected override float GetMovementInput() 
    {
        return Input.GetAxis("LeftPaddle");
    }

    public void OnHit(Collision2D collision) 
    {

    }

}
