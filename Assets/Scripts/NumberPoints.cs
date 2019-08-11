using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPoints : MonoBehaviour
{
    private Text m_Current_Text;
    private Text m_NumberPoints;
    public Spawnerboxes spawnerboxes;
    string abc = "asd";
    void Start()
    {
        m_Current_Text = GameObject.Find("NumberPoints").GetComponent<Text>();
        m_NumberPoints.text = abc;//PlayerPrefs.GetString("points");
        Debug.Log(m_NumberPoints);
        m_Current_Text.text += m_NumberPoints;

        // spawnerboxes = GetComponent<Spawnerboxes>();
        // m_Current_Text = GetComponent<Text>();
        // Debug.Log(spawnerboxes);
        // //m_NumberPoints.text = spawnerboxes.i.ToString();
        // m_Current_Text.text += m_NumberPoints;
    }

    /*void Update()
    {
        Debug.Log("m_Number " + m_NumberPoints);
    }*/
}
