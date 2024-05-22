using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public enum GameStates {inTitel, inGame, paused};
    public GameStates state = GameStates.inTitel;    

    public static GameManager instance;

    void Start()
    {
        instance = this;
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
        state = GameStates.inGame;
    }


}
