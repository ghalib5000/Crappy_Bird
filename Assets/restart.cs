using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      
        
    }
    public void startAgain()
    {
        Debug.Log("started again");
        SceneManager.LoadScene(0);
    }
}
