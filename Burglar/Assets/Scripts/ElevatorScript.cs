using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currentScene;

    [SerializeField] private AudioSource openDoor;
    [SerializeField] private AudioSource closeDoor;
    [SerializeField] private AudioSource elevatorButton;
    [SerializeField] private AudioSource elevatorMove;


    /// <summary>
    /// Вызывает внутри себя метод для проигрывания звуков лифта
    /// </summary>
    public void Elevator()
    {
        StartCoroutine(ElevatorMusicPause());
    }

    /// <summary>
    /// Проигрывает по очереди звуки движения лифта и открывает следующую сцену
    /// </summary>
    /// <returns></returns>
    IEnumerator ElevatorMusicPause()
    {
        openDoor.Play();
        yield return new WaitForSeconds(openDoor.clip.length);
        elevatorButton.Play();
        yield return new WaitForSeconds(elevatorButton.clip.length);
        closeDoor.Play();
        yield return new WaitForSeconds(closeDoor.clip.length);
        elevatorMove.Play();
        yield return new WaitForSeconds(elevatorMove.clip.length);
        openDoor.Play();
        yield return new WaitForSeconds(openDoor.clip.length);
        currentScene.SetActive(false);
        nextScene.SetActive(true);
    }
}
    
