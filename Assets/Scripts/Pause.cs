using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false); // Deaktiviert das Objekt beim Start
        GameManager.instance.pauseMenu = this;
    }
    public void GoToTitel()
    {
        GameManager.GoToTitel();
    }

    public void ToggelActive()
    {
        gameObject.SetActive(!gameObject.activeSelf); // Andere Schreibweise für (false)
        if (gameObject.activeSelf)
        {
            GameManager.instance.state = GameManager.GameStates.paused;
            Time.timeScale = 0; // Alles was Zeit hochzählt wird ausgesetzt
        }
        else
        {
            GameManager.instance.state = GameManager.GameStates.inGame;
            Time.timeScale = 1;              
        }
    }
}
