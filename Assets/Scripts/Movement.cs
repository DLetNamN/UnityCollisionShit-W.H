using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKey(KeyCode.W))
        {
            rBody.AddForce(new Vector2(0f, 20f), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rBody.AddForce(new Vector2(0f, -10f), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rBody.AddForce(new Vector2(10f, 0f), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rBody.AddForce(new Vector2(-10f, 0f), ForceMode2D.Force);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
