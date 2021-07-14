using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HollwayTimerScript : MonoBehaviour
{
    [SerializeField] private int limitTime;
    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currentScene;

    private TimerScript intervalTime = new TimerScript();

    private void OnEnable()
    {
        intervalTime.startTime = Time.time;
        intervalTime.intervalTime = limitTime;
    }

    private void Update()
    {
        // Через определённый промежуток переключает другую сцену
        if (intervalTime.LimitTime() <= 0)
        {
            nextScene.SetActive(true);
            currentScene.SetActive(false);
        }
    }
}
