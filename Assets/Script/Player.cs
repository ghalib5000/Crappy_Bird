using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D cam;
    public Vector2 offsets;
    public float y = 0;

    // Update is called once per frame
    void FixedUpdate()
    {   
        cam.AddForce(offsets * Time.fixedDeltaTime);
        if (Input.GetButton("Jump"))
        {
            offsets.y = y;
            cam.AddForce(offsets * Time.fixedDeltaTime);
            offsets.y = 0;

        }
    }

}
