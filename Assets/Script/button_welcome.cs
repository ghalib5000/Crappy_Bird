using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_welcome : MonoBehaviour
{
    public Rigidbody2D rb, rdcop;
    public Vector2 offsets;
    public float y = 0, x = 8;
    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 0;
        rdcop.gravityScale = 0;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
   
        rb.AddForce(-offsets * Time.fixedDeltaTime);
        rdcop.AddForce(-offsets * Time.fixedDeltaTime);
     }

    private void Update()
    {
    }
}
