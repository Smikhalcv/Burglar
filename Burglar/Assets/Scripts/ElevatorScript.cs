using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public AudioSource openDoor;
    public AudioSource closeDoor;
    public AudioSource elevatorButton;
    public AudioSource elevatorMove;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Elevator()
    {
        StartCoroutine(ElevatorMusicPause());
    }

    IEnumerator ElevatorMusicPause()
    {
        openDoor.Play();
        Debug.Log("start");
        yield return new WaitForSeconds(openDoor.clip.length);
        Debug.Log(openDoor.clip.length);
        elevatorButton.Play();
        yield return new WaitForSeconds(elevatorButton.clip.length);
        Debug.Log(elevatorButton.clip.length);
        closeDoor.Play();
        yield return new WaitForSeconds(closeDoor.clip.length);
        Debug.Log(closeDoor.clip.length);
        elevatorMove.Play();
        yield return new WaitForSeconds(elevatorMove.clip.length);
        Debug.Log(elevatorMove.clip.length);
        openDoor.Play();
    }
}
    
