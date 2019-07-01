using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 offsets;
    public float y = 0,x=8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(offsets * Time.fixedDeltaTime);

        if (Input.GetKey("space"))
        {
            offsets.x = x;
            offsets.y = y;
            rb.AddForce(offsets * Time.fixedDeltaTime);
            offsets.y = 0;
            
        }
    }
}
