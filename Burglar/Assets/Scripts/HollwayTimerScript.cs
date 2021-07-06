using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HollwayTimerScript : MonoBehaviour
{
    private float currectTime;
    public int timer;
    [SerializeField] GameObject nextScene;
    [SerializeField] GameObject currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currectTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {   
        // Через определённый промежуток переключает другую сцену
        if (Time.time - currectTime > timer)
        {
            nextScene.SetActive(true);
            currentScene.SetActive(false);
        }
    }
}
