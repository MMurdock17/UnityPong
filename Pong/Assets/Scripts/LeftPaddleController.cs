using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class LeftPaddleController : PaddleController, ICollidable
{

    private NetworkVariable<float> paddleYPosition = new NetworkVariable<float>(0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOwner)
        {
            float velocity = GetMovementInput();
            transform.position += new Vector3(0, velocity * speed * Time.deltaTime, 0);
            paddleYPosition.Value = transform.position.y;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, paddleYPosition.Value, 0);
        }

        if (!IsSpawned)
        {
            return;
        }
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
