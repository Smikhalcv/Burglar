using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HollwayTimerScript : MonoBehaviour
{
    [SerializeField] private Text limitTimeOutPutText;
    [SerializeField] private int limitTime;
    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currentScene;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // Через определённый промежуток переключает другую сцену
        if (Time.time - startTime > limitTime)
        {
            nextScene.SetActive(true);
            currentScene.SetActive(false);
        }
        // Вывод отсчёта на экран
        limitTimeOutPutText.text = Math.Round(limitTime - (Time.time - startTime)).ToString();
    }
}
