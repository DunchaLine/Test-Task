using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuUI : MonoBehaviour
{
    public void StartButton()
    {
        Application.LoadLevel("SampleScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
