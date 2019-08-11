using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject obj;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (!isPaused){
                Time.timeScale = 0;
                isPaused = true;
                obj.SetActive(true);
            }
            else if(isPaused){
                Time.timeScale = 1;
                isPaused = false;
                obj.SetActive(false);
            }
            
        }
    }
}
