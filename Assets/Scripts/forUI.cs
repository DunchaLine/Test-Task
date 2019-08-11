using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forUI : MonoBehaviour
{
    public void Restart()
    {
        Application.LoadLevel("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
