using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HollwayTimerScript : MonoBehaviour
{
    [SerializeField] private Text timerText;

    private float currectTime;
    [SerializeField] private int timer;

    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currectTime = Time.time;
    }

    //// При перезапуске страницы смена сцен
    //private void OnEnable()
    //{
    //    currectTime = Time.time;
    //}

    // Update is called once per frame
    void Update()
    {
        // Через определённый промежуток переключает другую сцену
        if (Time.time - currectTime > timer)
        {
            nextScene.SetActive(true);
            currentScene.SetActive(false);
        }
        // Вывод отсчёта на экран
        timerText.text = Math.Round(timer - (Time.time - currectTime)).ToString();
    }
}
