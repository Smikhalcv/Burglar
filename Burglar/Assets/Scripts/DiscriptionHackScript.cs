using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DiscriptionHackScript : MonoBehaviour
{
    [SerializeField] private Text limitTimeOutPutText;
    [SerializeField] private int limitTime;
    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currentScene;


    private TimerScript intervalTime = new TimerScript();

    private void Start()
    {
        intervalTime.startTime = Time.time;
        intervalTime.intervalTime = limitTime;
    }

    private void Update()
    {
        // ����� ����������� ���������� ����������� ������ �����
        if (intervalTime.LimitTime() <= 0)
        {
            nextScene.SetActive(true);
            currentScene.SetActive(false);
        }
        OutPutTimeLeft();
    }

    /// <summary>
    /// ������� ������� ������� �� �����
    /// </summary>
    private void OutPutTimeLeft()
    {
        limitTimeOutPutText.text = intervalTime.LimitTime().ToString();
    }
}
