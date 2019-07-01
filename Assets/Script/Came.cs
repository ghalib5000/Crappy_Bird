using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Came : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 offsets;
    

    // Update is called once per frame
    void Update()
    {
            rb.AddForce(offsets * Time.fixedDeltaTime);
     }
}
