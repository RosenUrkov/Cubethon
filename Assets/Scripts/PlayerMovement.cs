using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int FORWARD_FORCE = 2000;
    public int MOVEMENT_FORCE = 70;


    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, FORWARD_FORCE * Time.deltaTime);

        if(Input.GetKey("a"))
        {
            rigidBody.AddForce(-MOVEMENT_FORCE * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("d"))
        {
            rigidBody.AddForce(MOVEMENT_FORCE * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rigidBody.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
    