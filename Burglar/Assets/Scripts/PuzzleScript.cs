using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    public Button[] buttons = new Button[9];
    public Sprite[] buttonColor = new Sprite[2];
    [SerializeField] GameObject nextScene;
    [SerializeField] GameObject currentScene;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].image.sprite = buttonColor[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (buttons[0].image == buttonColor[1] &&
            buttons[1].image == buttonColor[1] &&
            buttons[2].image == buttonColor[1] &&
            buttons[3].image == buttonColor[1] &&
            buttons[4].image == buttonColor[1] &&
            buttons[5].image == buttonColor[1] &&
            buttons[6].image == buttonColor[1] &&
            buttons[7].image == buttonColor[1] &&
            buttons[8].image == buttonColor[1]
            )
        {
            nextScene.SetActive(true);
            currentScene.SetActive(false);
        }
    }

    /// <summary>
    /// Меняет цвета соседних кнопок на противоположные, если все цыета зелённые то проверка пройдена
    /// </summary>
    /// <param name="value">значение кнопки</param>
    public void PuzzleButton(int value)
    {
        if (value == 0)
        {
            if (buttons[0].image.sprite == buttonColor[0]) { buttons[0].image.sprite = buttonColor[1]; } else { buttons[0].image.sprite = buttonColor[0]; }
            if (buttons[1].image.sprite == buttonColor[0]) { buttons[1].image.sprite = buttonColor[1]; } else { buttons[1].image.sprite = buttonColor[0]; }
            if (buttons[3].image.sprite == buttonColor[0]) { buttons[3].image.sprite = buttonColor[1]; } else { buttons[3].image.sprite = buttonColor[0]; }
        }
        else if (value == 1)
        {
            if (buttons[1].image.sprite == buttonColor[0]) { buttons[1].image.sprite = buttonColor[1]; } else { buttons[1].image.sprite = buttonColor[0]; }
            if (buttons[0].image.sprite == buttonColor[0]) { buttons[0].image.sprite = buttonColor[1]; } else { buttons[0].image.sprite = buttonColor[0]; }
            if (buttons[2].image.sprite == buttonColor[0]) { buttons[2].image.sprite = buttonColor[1]; } else { buttons[2].image.sprite = buttonColor[0]; }
            if (buttons[4].image.sprite == buttonColor[0]) { buttons[4].image.sprite = buttonColor[1]; } else { buttons[4].image.sprite = buttonColor[0]; }
        }
        else if (value == 2)
        {
            if (buttons[2].image.sprite == buttonColor[0]) { buttons[2].image.sprite = buttonColor[1]; } else { buttons[2].image.sprite = buttonColor[0]; }
            if (buttons[1].image.sprite == buttonColor[0]) { buttons[1].image.sprite = buttonColor[1]; } else { buttons[1].image.sprite = buttonColor[0]; }
            if (buttons[5].image.sprite == buttonColor[0]) { buttons[5].image.sprite = buttonColor[1]; } else { buttons[5].image.sprite = buttonColor[0]; }
        }
        else if (value == 3)
        {
            if (buttons[3].image.sprite == buttonColor[0]) { buttons[3].image.sprite = buttonColor[1]; } else { buttons[3].image.sprite = buttonColor[0]; }
            if (buttons[0].image.sprite == buttonColor[0]) { buttons[0].image.sprite = buttonColor[1]; } else { buttons[0].image.sprite = buttonColor[0]; }
            if (buttons[6].image.sprite == buttonColor[0]) { buttons[6].image.sprite = buttonColor[1]; } else { buttons[6].image.sprite = buttonColor[0]; }
            if (buttons[4].image.sprite == buttonColor[0]) { buttons[4].image.sprite = buttonColor[1]; } else { buttons[4].image.sprite = buttonColor[0]; }
        }
        else if (value == 4)
        {
            if (buttons[1].image.sprite == buttonColor[0]) { buttons[1].image.sprite = buttonColor[1]; } else { buttons[1].image.sprite = buttonColor[0]; }
            if (buttons[3].image.sprite == buttonColor[0]) { buttons[3].image.sprite = buttonColor[1]; } else { buttons[3].image.sprite = buttonColor[0]; }
            if (buttons[5].image.sprite == buttonColor[0]) { buttons[5].image.sprite = buttonColor[1]; } else { buttons[5].image.sprite = buttonColor[0]; }
            if (buttons[7].image.sprite == buttonColor[0]) { buttons[7].image.sprite = buttonColor[1]; } else { buttons[7].image.sprite = buttonColor[0]; }
            if (buttons[4].image.sprite == buttonColor[0]) { buttons[4].image.sprite = buttonColor[1]; } else { buttons[4].image.sprite = buttonColor[0]; }
        }
        else if (value == 5)
        {
            if (buttons[5].image.sprite == buttonColor[0]) { buttons[5].image.sprite = buttonColor[1]; } else { buttons[5].image.sprite = buttonColor[0]; }
            if (buttons[2].image.sprite == buttonColor[0]) { buttons[2].image.sprite = buttonColor[1]; } else { buttons[2].image.sprite = buttonColor[0]; }
            if (buttons[8].image.sprite == buttonColor[0]) { buttons[8].image.sprite = buttonColor[1]; } else { buttons[8].image.sprite = buttonColor[0]; }
            if (buttons[4].image.sprite == buttonColor[0]) { buttons[4].image.sprite = buttonColor[1]; } else { buttons[4].image.sprite = buttonColor[0]; }
        }
        else if (value == 6)
        {
            if (buttons[6].image.sprite == buttonColor[0]) { buttons[6].image.sprite = buttonColor[1]; } else { buttons[6].image.sprite = buttonColor[0]; }
            if (buttons[3].image.sprite == buttonColor[0]) { buttons[3].image.sprite = buttonColor[1]; } else { buttons[3].image.sprite = buttonColor[0]; }
            if (buttons[7].image.sprite == buttonColor[0]) { buttons[7].image.sprite = buttonColor[1]; } else { buttons[7].image.sprite = buttonColor[0]; }
        }
        else if (value == 7)
        {
            if (buttons[7].image.sprite == buttonColor[0]) { buttons[7].image.sprite = buttonColor[1]; } else { buttons[7].image.sprite = buttonColor[0]; }
            if (buttons[6].image.sprite == buttonColor[0]) { buttons[6].image.sprite = buttonColor[1]; } else { buttons[6].image.sprite = buttonColor[0]; }
            if (buttons[8].image.sprite == buttonColor[0]) { buttons[8].image.sprite = buttonColor[1]; } else { buttons[8].image.sprite = buttonColor[0]; }
            if (buttons[4].image.sprite == buttonColor[0]) { buttons[4].image.sprite = buttonColor[1]; } else { buttons[4].image.sprite = buttonColor[0]; }
        }
        else if (value == 8)
        {
            if (buttons[8].image.sprite == buttonColor[0]) { buttons[8].image.sprite = buttonColor[1]; } else { buttons[8].image.sprite = buttonColor[0]; }
            if (buttons[5].image.sprite == buttonColor[0]) { buttons[5].image.sprite = buttonColor[1]; } else { buttons[5].image.sprite = buttonColor[0]; }
            if (buttons[7].image.sprite == buttonColor[0]) { buttons[7].image.sprite = buttonColor[1]; } else { buttons[7].image.sprite = buttonColor[0]; }
        }
    }
}
