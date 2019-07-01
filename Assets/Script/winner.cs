using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winner : MonoBehaviour
{
    public Rigidbody2D player;
    public Vector2 off;
   
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //todo
        Debug.Log("You Win");
        off.x = 0;
        off.y = 0;
        player.AddForce(off);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
