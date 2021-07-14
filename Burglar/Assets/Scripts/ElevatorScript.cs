using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currentScene;

    [SerializeField] private AudioSource openDoorSound;
    [SerializeField] private AudioSource closeDoorSound;
    [SerializeField] private AudioSource elevatorButtonSound;
    [SerializeField] private AudioSource elevatorMoveSound;


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
    IEnumerator ElevatorMusicPause()
    {
        openDoorSound.Play();
        yield return new WaitForSeconds(openDoorSound.clip.length);
        elevatorButtonSound.Play();
        yield return new WaitForSeconds(elevatorButtonSound.clip.length);
        closeDoorSound.Play();
        yield return new WaitForSeconds(closeDoorSound.clip.length);
        elevatorMoveSound.Play();
        yield return new WaitForSeconds(elevatorMoveSound.clip.length);
        openDoorSound.Play();
        yield return new WaitForSeconds(openDoorSound.clip.length);
        currentScene.SetActive(false);
        nextScene.SetActive(true);
    }
}
    
