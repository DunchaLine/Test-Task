using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forUI : MonoBehaviour
{
    private int score = 0;
    public Text losing_score;

    public void Start()
    {
        if (PlayerPrefs.HasKey("player_score")){
            score = PlayerPrefs.GetInt("player_score");
        }
        losing_score.text += (score).ToString();
    }
    public void Restart()
    {
        Application.LoadLevel("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
