using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{ 
    private GameObject firstScene;

    public GameObject currectScene;

    // Start is called before the first frame update
    void Start()
    {
        firstScene = currectScene;
        firstScene.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// Переключает сцену на указанную закрывая предыдущую
    /// </summary>
    /// <param name="nextScene">Следующая сцена</param>
    public void ChangeScene(GameObject nextScene)
    {
        currectScene.SetActive(false);
        currectScene = nextScene;
        currectScene.SetActive(true);
    }
}
