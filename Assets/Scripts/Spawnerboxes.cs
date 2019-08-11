using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerboxes : MonoBehaviour
{
    public float minTime; 
    public float maxTime;
    public GameObject objToSpawn; //объект, который будет появляться
    public float timeForDestroy;
    public float minSize;
    public float maxSize;
    public int i;
    int increaseTime = 1000;
    GameObject obj;
    public Text points;
    public bool isPaused = false;
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
        if (!isPaused){
            i++; 
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
        if (i >= 2000){
            Application.LoadLevel("win_scene");
        }
        Debug.Log("counter: " + i);
    }
}
