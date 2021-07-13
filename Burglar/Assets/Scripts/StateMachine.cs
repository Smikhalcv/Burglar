using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{ 
    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currectScene;
    
    /// <summary>
    /// Переключает сцену на указанную закрывая предыдущую
    /// </summary>
    /// <param name="nextScene">Следующая сцена</param>
    public void ChangeScene()
    {
        currectScene.SetActive(false);
        nextScene.SetActive(true);
    }
}
