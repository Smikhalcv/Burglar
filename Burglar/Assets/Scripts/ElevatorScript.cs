using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    [SerializeField] private GameObject nextScene;
    [SerializeField] private GameObject currentScene;

    public AudioSource openDoor;
    public AudioSource closeDoor;
    public AudioSource elevatorButton;
    public AudioSource elevatorMove;


    /// <summary>
    /// �������� ������ ���� ����� ��� ������������ ������ �����
    /// </summary>
    public void Elevator()
    {
        StartCoroutine(ElevatorMusicPause());
    }

    /// <summary>
    /// ����������� �� ������� ����� �������� ����� � ��������� ��������� �����
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
    
