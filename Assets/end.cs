using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameObject gc;
    public Animator anim;

    public Rigidbody2D player, cam;
    public Collider2D cd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gc.SetActive(true);
        anim.speed = 1;
        anim.enabled = true;
        Debug.Log("game ended");
          // cd.isTrigger = false;
        Invoke("pause", 5);
     singularity();
    }
    public void singularity()
    {
        player.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        cam.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
     }
    private void pause()
    {
        anim.speed = 0;
    }

    private void Start()
    {
        gc.SetActive(false);
        anim.speed = 0;
    }
}
