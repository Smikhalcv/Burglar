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

    //// ��� ����������� �������� ����� ����
    //private void OnEnable()
    //{
    //    currectTime = Time.time;
    //}

    // Update is called once per frame
    void Update()
    {
        // ����� ����������� ���������� ����������� ������ �����
        if (Time.time - currectTime > timer)
        {
            nextScene.SetActive(true);
            currentScene.SetActive(false);
        }
        // ����� ������� �� �����
        timerText.text = Math.Round(timer - (Time.time - currectTime)).ToString();
    }
}
