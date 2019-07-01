using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 offsets;
    public float y = 0, x = 8, horizontal;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(offsets * Time.fixedDeltaTime);


        if (Input.GetButton("Jump"))
        {
            offsets.y = y;
            rb.AddForce(offsets * Time.fixedDeltaTime);
            offsets.y = 0;

        }
        if (horizontal != 0)
        {
            offsets.x = horizontal * 100;
            rb.AddForce(offsets * Time.fixedDeltaTime);
            offsets.x = x;
            
        }
    }
    void Update()
    {
     horizontal = Input.GetAxisRaw("Horizontal");
    }
}
