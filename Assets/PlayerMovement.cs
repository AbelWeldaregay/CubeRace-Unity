﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update

    //marked this as "Fixed"Update becasue
    //we are using it to mess with physics  
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if( Input.GetKey("e") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }


    }
}
