using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerboxes : MonoBehaviour
{
    public float minTime;         //минимальное время с которым будут появляться платформы
    public float maxTime;         //максимальное время 
    public GameObject objToSpawn; //объект, который будет появляться
    public float timeForDestroy;  //время на уничтожение объекта
    public float minSize;         //минимальный размер объекта
    public float maxSize;         //максимальный размер объекта
    private int i;                 //счетчик фреймов
    private int score;
    int increaseTime = 1000;      //порог, при котором повышается сложность игры
    GameObject obj;
    public Text points;            //количество очков, которое выводится на экране
    public bool isPaused = false;  //проверка на паузу
    public GameObject pauseObj;

    void Start()
    {
        StartCoroutine(Spawner());
        //DontDestroyOnLoad(points);
    }

    IEnumerator Spawner () {
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        Spawn();
    }
    
    void Spawn()
    {
        obj = Instantiate(objToSpawn,
         transform.position, transform.rotation);
        obj.transform.localScale = new Vector3(.2f, .2f, Random.Range(minSize, maxSize));
        StartCoroutine(Spawner());
    }

    void Update(){
        Destroy(obj, timeForDestroy);
        i++; 
        PlayerPrefs.SetInt("player_score", score);
        if (!isPaused && i >= 103){
            score++;
            points.text = (double.Parse(points.text) + .5).ToString();
            if (Input.GetKeyDown(KeyCode.Escape)){
                Time.timeScale = 0;
                isPaused = true;
                pauseObj.SetActive(true);
            }
        }
        else if (isPaused){
            if (Input.GetKeyDown(KeyCode.Escape)){
                Time.timeScale = 1;
                isPaused = false;
                pauseObj.SetActive(false);
            }
        }
        if (i >= increaseTime){
            maxTime += .07f;
            maxSize -= .3f;
            increaseTime += 500;
        }
        if (score == 2000){
            Application.LoadLevel("win_scene");
        }
        Debug.Log("score " + score);
    }
}
