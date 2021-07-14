using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BasementAlarmBoardLockScript : MonoBehaviour
{
    [SerializeField] private Text slider1;
    [SerializeField] private Text slider2;
    [SerializeField] private Text slider3;
    [SerializeField] private Text slider4;
    [SerializeField] private Text timer;
    [SerializeField] private GameObject sceneFail;
    [SerializeField] private GameObject sceneNext;
    [SerializeField] private GameObject sceneCurrent;
    private float currentTime;
    private int timeHaking;
    private int[] sliders = new int[4];
    private int[,] combinPickLock = new int[4, 4] { 
                                                    { 1, -1, 0, 1 }, 
                                                    { 0, 1, -1, 0 }, 
                                                    { 0, 1, 1, -1 }, 
                                                    { -1, 0, 1, 0 } 
                                                    };

    System.Random rnd = new System.Random();

    private void Start()
    {
        NewCombination();
        currentTime = Time.time;
        timeHaking = 60;
    }

    /// <summary>
    /// Перезаписвает время и гнрирует новую комбинацию для каждой новой игры
    /// </summary>
    private void OnEnable()
    {
        currentTime = Time.time;
        NewCombination();
    }

    private void Update()
    {
        // Передаёт значения комбинации на экране
        slider1.text = sliders[0].ToString();
        slider2.text = sliders[1].ToString();
        slider3.text = sliders[2].ToString();
        slider4.text = sliders[3].ToString();

        // Выводит таймер на экран
        timer.text = Math.Round(timeHaking - (Time.time - currentTime)).ToString();
        // Провряет время до истечния таймера
        if (timeHaking - (Time.time - currentTime) < 0)
        {
            NewCombination();
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
        Debug.Log("Кнопка нажата");
        for (int i = 0; i < sliders.Length; i++) // Изменяет комбинацию в зависимости от отмычки,
                                                 // если хоть одно значение выходит за пределы объявляет проигрыш
        {
            sliders[i] += combinPickLock[numberPickLock, i];
            if (sliders[i] > 9 || sliders[i] < 0)
            {
                Debug.Log("Вышли за рамки");
                NewCombination();
                sceneCurrent.SetActive(false);
                sceneFail.SetActive(true);
                break;
            }
            
        }
        // проверяет значения комбинации на условие выйгроша
        if (sliders[0] == sliders[1] && sliders[1] == sliders[2] && sliders[2] == sliders[3]) 
        {
            NewCombination();
            sceneNext.SetActive(true);
            sceneCurrent.SetActive(false);
        }
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
    }
}
