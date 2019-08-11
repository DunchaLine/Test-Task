using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTheGame : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player"){
            Application.LoadLevel("lose_scene");
        }
    }
}