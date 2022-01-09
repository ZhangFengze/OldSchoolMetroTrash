using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var move = new Vector3(0, 0, 0);
        if(Input.GetKey(KeyCode.W))
        {
            move.z += 1;
        }
        if(Input.GetKey(KeyCode.S))
        {
            move.z -= 1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            move.x -= 1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            move.x += 1;
        }
        if(move==Vector3.zero)
        {
            rb.velocity *= 0.96f;
        }
        else
        {
            rb.velocity = Vector3.MoveTowards(rb.velocity, move * 10, Time.deltaTime * 100);
        }
        Camera.main.transform.position = rb.position + new Vector3(0, 2, -5);
    }
}
