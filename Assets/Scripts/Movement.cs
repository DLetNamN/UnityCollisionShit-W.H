using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rBody;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //AddForce
        //.velocity
        //( MovePosition() )

        //AddTorque
        //.anuglarVelocity
        //


    }

    void FixedUpdate()
    {
        rBody.AddForce(new Vector2(10f, 0f), ForceMode2D.Force);
    }
}
