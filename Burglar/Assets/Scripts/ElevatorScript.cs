using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    [SerializeField] GameObject nextScene;
    [SerializeField] GameObject currentScene;

    public AudioSource openDoor;
    public AudioSource closeDoor;
    public AudioSource elevatorButton;
    public AudioSource elevatorMove;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

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
        StateMachine changeScene = new StateMachine();
        changeScene.currectScene = currentScene;
        changeScene.ChangeScene(nextScene);
    }
}
    
