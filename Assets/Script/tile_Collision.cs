using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tile_Collision : MonoBehaviour
{
    public Rigidbody2D player, cam;
    public Animator planim;
    public GameObject over;
    private void OnCollisionEnter2D(Collision2D collision)
    {
      Debug.Log("collision!");
        singularity();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO
        Debug.Log("you lose");
        singularity();
        over.SetActive(true);
    }
    private void singularity()
    {
        player.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        cam.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        planim.enabled = false;
    }
}

