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
    [SerializeField] GameObject sceneFail;
    [SerializeField] GameObject sceneNext;
    [SerializeField] GameObject sceneCurrent;
    int[] sliders = new int[4];
    System.Random rnd = new System.Random();
    int[,] combinPickLock = new int[4, 4] { 
                                            { 1, -1, 0, 1 }, 
                                            { 0, 1, -1, 0 }, 
                                            { 0, 1, 1, -1 }, 
                                            { -1, 0, 1, 0 } 
                                            };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sliders.Length; i++)
        {
            sliders[i] = rnd.Next(7) + 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        slider1.text = sliders[0].ToString();
        slider2.text = sliders[1].ToString();
        slider3.text = sliders[2].ToString();
        slider4.text = sliders[3].ToString();
    }

    public void PickLock(int numberPickLock)
    {
        Debug.Log("Кнопка нажата");
        for (int i = 0; i < sliders.Length; i++)
        {
            sliders[i] += combinPickLock[numberPickLock, i];
            if (sliders[i] > 9 || sliders[i] < 0)
            {
                Debug.Log("Вышли за рамки");
                sceneFail.SetActive(true);
                sceneCurrent.SetActive(false);
                break;
            }
            
        }
        if (sliders[0] == sliders[1] && sliders[1] == sliders[2] && sliders[2] == sliders[3])
        {
            sceneNext.SetActive(true);
            sceneCurrent.SetActive(false);
        }
    }
}
