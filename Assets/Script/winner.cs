using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour
{
    public Rigidbody2D player;
    public Vector2 off;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //todo
        Debug.Log("You Win");
        off.x = 0;
        off.y = 0;
        player.AddForce(off);
    }
}
