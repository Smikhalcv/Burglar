using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BasementAlarmBoardLockScript : MonoBehaviour
{
    [SerializeField] private Text valueSlider1;
    [SerializeField] private Text valueSlider2;
    [SerializeField] private Text valueSlider3;
    [SerializeField] private Text valueSlider4;
    [SerializeField] private Text leftTimeText;
    [SerializeField] private GameObject sceneFail;
    [SerializeField] private GameObject sceneNext;
    [SerializeField] private GameObject sceneCurrent;
    private int[] sliders = new int[4];
    private int[,] combinPickLock = new int[4, 4] { 
                                                    { 1, -1, 0, 1 }, 
                                                    { 0, 1, -1, 0 }, 
                                                    { 0, 1, 1, -1 }, 
                                                    { -1, 0, 1, 0 } 
                                                    };

    System.Random rnd = new System.Random();
    private TimerScript leftTime = new TimerScript();

    private void Start()
    {
        leftTime.startTime = Time.time;
        leftTime.intervalTime = 60;
    }

    /// <summary>
    /// Перезаписвает время и гнрирует новую комбинацию для каждой новой игры
    /// </summary>
    private void OnEnable()
    {
        leftTime.startTime = Time.time;
        NewCombination();
    }

    private void Update()
    {
        // Выводит таймер на экран
        leftTimeText.text = leftTime.LimitTime().ToString();
        // Провряет время до истечния таймера
        if (leftTime.LimitTime() <= 0)
        {
            sceneCurrent.SetActive(false);
            sceneFail.SetActive(true);
        }
    }

    /// <summary>
    /// Принимает номр отмычки и в зависимости от этого меняет комбинацию.
    /// Проверяет граничные значения в комбинации.
    /// </summary>
    /// <param name="numberPickLock">Номер отмычки</param>
    public void PickLock(int numberPickLock)
    {
        for (int i = 0; i < sliders.Length; i++) // Изменяет комбинацию в зависимости от отмычки,
                                                 // если хоть одно значение выходит за пределы объявляет проигрыш
        {
            sliders[i] += combinPickLock[numberPickLock, i];
            if (sliders[i] > 9 || sliders[i] < 0)
            {
                sceneCurrent.SetActive(false);
                sceneFail.SetActive(true);
                break;
            }
            
        }
        CheckWin();
        OutPutValueSliders();
    }

    /// <summary>
    /// Создаёт случайные значения для шифра от 2 до 8
    /// </summary>
    private void NewCombination()
    {
        for (int i = 0; i < sliders.Length; i++)
        {
            sliders[i] = rnd.Next(7) + 2;
        }
        OutPutValueSliders();
    }

    /// <summary>
    /// Выводит значение ползунков на экран
    /// </summary>
    private void OutPutValueSliders()
    {
        valueSlider1.text = sliders[0].ToString();
        valueSlider2.text = sliders[1].ToString();
        valueSlider3.text = sliders[2].ToString();
        valueSlider4.text = sliders[3].ToString();
    }

    /// <summary>
    /// Проверяет условия открытия замка
    /// </summary>
    private void CheckWin()
    {
        if (sliders[0] == sliders[1] && sliders[1] == sliders[2] && sliders[2] == sliders[3])
        {
            NewCombination();
            sceneNext.SetActive(true);
            sceneCurrent.SetActive(false);
        }
    }
}
