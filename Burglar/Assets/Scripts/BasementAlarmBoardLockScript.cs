using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BasementAlarmBoardLockScript : MonoBehaviour
{
    [SerializeField] Text slider1;
    [SerializeField] Text slider2;
    [SerializeField] Text slider3;
    [SerializeField] Text slider4;
    [SerializeField] Text timer;

    [SerializeField] GameObject sceneFail;
    [SerializeField] GameObject sceneNext;
    [SerializeField] GameObject sceneCurrent;

    float currentTime;
    int timeHaking;

    int[] sliders = new int[4];
    System.Random rnd = new System.Random();
    int[,] combinPickLock = new int[4, 4] { 
                                            { 1, -1, 0, 1 }, 
                                            { 0, 1, -1, 0 }, 
                                            { 0, 1, 1, -1 }, 
                                            { -1, 0, 1, 0 } 
                                            };

    StateMachine changeScene = new StateMachine();
    
    // Start is called before the first frame update
    void Start()
    {
        NewCombination();
        currentTime = Time.time;
        timeHaking = 60;
        changeScene.currectScene = sceneCurrent;
    }

    /// <summary>
    /// Перезаписвает время и гнрирует новую комбинацию для каждой новой игры
    /// </summary>
    private void OnEnable()
    {
        currentTime = Time.time;
        NewCombination();
        changeScene.currectScene = sceneCurrent;
    }

    // Update is called once per frame
    void Update()
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
            //StateMachine changeScene = new StateMachine();
            //changeScene.currectScene = sceneCurrent;
            changeScene.ChangeScene(sceneFail);
            //sceneFail.SetActive(true);
            //sceneCurrent.SetActive(false);
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
                //StateMachine changeScene = new StateMachine();
                //changeScene.currectScene = sceneCurrent;
                changeScene.ChangeScene(sceneFail);
                //sceneFail.SetActive(true);
                //sceneCurrent.SetActive(false);
                break;
            }
            
        }
        // проверяет значения комбинации на условие выйгроша
        if (sliders[0] == sliders[1] && sliders[1] == sliders[2] && sliders[2] == sliders[3]) 
        {
            NewCombination();
            //StateMachine changeScene = new StateMachine();
            //changeScene.currectScene = sceneCurrent;
            changeScene.ChangeScene(sceneNext);
            //sceneNext.SetActive(true);
            //sceneCurrent.SetActive(false);
        }
    }

    /// <summary>
    /// Создаёт случайные значения для шифра от 2 до 8
    /// </summary>
    void NewCombination()
    {
        for (int i = 0; i < sliders.Length; i++)
        {
            sliders[i] = rnd.Next(7) + 2;
        }
    }
}
