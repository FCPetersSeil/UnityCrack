using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public enum GameStates {inTitel, inGame, paused};
    public GameStates state = GameStates.inTitel;    

    public static GameManager instance;
    public float GameTimer = 180;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
        
    }
    public static void GoToGame()
    {
        SceneManager.LoadScene("Game");
        instance.state = GameStates.inGame;
    }

    void Update()
    {
        if(state == GameStates.inGame)
        {
            GameTimer -= Time.deltaTime;
            if(GameTimer <= 0)
            {
                SceneManager.LoadScene("Titel");
                state = GameStates.inTitel; 
                GameTimer = 180;
            }
        }

    }

}
