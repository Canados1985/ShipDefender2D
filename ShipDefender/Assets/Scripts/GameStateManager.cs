using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameStateManager : MonoBehaviour {

    public static GameStateManager cl_GameStateManager;
    public GameObject[] gameStates;
    public enum GameStates { MENU, GAME, PAUSE, GAMEOVER, GAMEWIN }
    private GameStates e_gameStates;
    public GameObject go_MenuCamera;

    bool Is_IntroActive = false;
    public bool b_IsGameIsPaused = false;
    public bool b_IsGameMode = false;

    public GameObject go_IntroPanel;
    public GameObject go_MenuPanel;

    public GameObject go_StartButtonIntro;

    public GameObject go_IntroText;

    public Text introText;
    public Color textColor;

    void Start() {

        cl_GameStateManager = this;

        go_MenuPanel.SetActive(true);
        go_IntroPanel.SetActive(false);
        go_StartButtonIntro.SetActive(false);
    }
    // Game Manu State
    public void GameMenu()
    {
        cl_GameStateManager = this;
        e_gameStates = GameStates.MENU;
        ChangeGameStates();
        go_MenuCamera.SetActive(true);
        FindObjectOfType<AudioManager>().Play("menuTheme");
    }
    // Game Intro State
    public void GameIntro()
    {
        go_MenuPanel.SetActive(false);
        go_IntroPanel.SetActive(true);
        FindObjectOfType<AudioManager>().Stop("menuTheme");
        FindObjectOfType<AudioManager>().Play("introTheme");
        Is_IntroActive = true;
        introText = go_IntroText.GetComponent<Text>();
        textColor.a = introText.color.a;

        Debug.Log("TEXT COLOR BEFORE " + textColor.a);
        textColor.a = 0;
        Debug.Log("TEXT COLOR AFTER " + textColor.a);
    }
    // Game State
    public void StartGame()
    {
        b_IsGameMode = true;
        Is_IntroActive = false;
        go_StartButtonIntro.SetActive(false);
        e_gameStates = GameStates.GAME;
        ChangeGameStates();
        FindObjectOfType<AudioManager>().Stop("introTheme");
        FindObjectOfType<AudioManager>().Play("mainTheme");
        FindObjectOfType<AudioManager>().Stop("gameoverTheme");
    }
    // Game Pause State
    public void PauseGame()
    {
        e_gameStates = GameStates.PAUSE;
        ChangeGameStates();
        b_IsGameMode = false;
        b_IsGameIsPaused = true;
        Time.timeScale = 0f;
        FindObjectOfType<AudioManager>().Pause("mainTheme");
    }
    // Game Unpause State
    public void UnpausedGame()
    {
        e_gameStates = GameStates.GAME;
        ChangeGameStates();
        b_IsGameMode = true;
        b_IsGameIsPaused = false;
        Time.timeScale = 1f;
        FindObjectOfType<AudioManager>().Unpause("mainTheme");
    }
    // Game Over State
    internal void GameOver()
    {
        gameStates[1].SetActive(false);
        gameStates[3].SetActive(true);
        FindObjectOfType<AudioManager>().Stop("mainTheme");
        FindObjectOfType<AudioManager>().Play("gameoverTheme");
    }
    // Game Win State
    internal void GameWin()
    {
        gameStates[1].SetActive(false);
        gameStates[4].SetActive(true);
        FindObjectOfType<AudioManager>().Stop("mainTheme");

    }
    // Game Exit
    public void GameExit()
    {
        Application.Quit();
    }


    public void ReloadScene()
    { SceneManager.LoadScene(0); }



    // Switching between scenes based on ENUM
    private void ChangeGameStates()
    {

        switch (e_gameStates)
        {
            case GameStates.MENU:
                gameStates[0].SetActive(true); // MENU
                gameStates[1].SetActive(false); // GAME
                gameStates[2].SetActive(false); // PAUSE
                gameStates[3].SetActive(false); // GAMEOVER
                gameStates[4].SetActive(false); // GAMEWIN


                break;

            case GameStates.GAME:
                gameStates[0].SetActive(false); // MENU
                gameStates[1].SetActive(true); // GAME
                gameStates[2].SetActive(false); // PAUSE
                gameStates[3].SetActive(false); // GAMEOVER
                gameStates[4].SetActive(false); // GAMEWIN

                break;

            case GameStates.PAUSE:
                gameStates[0].SetActive(false); // MENU
                gameStates[1].SetActive(true); // GAME
                gameStates[2].SetActive(true); // PAUSE
                gameStates[3].SetActive(false); // GAMEOVER
                gameStates[4].SetActive(false); // GAMEWIN
                break;

            case GameStates.GAMEOVER:
                gameStates[0].SetActive(false); // MENU
                gameStates[1].SetActive(false); // GAME
                gameStates[2].SetActive(false); // PAUSE
                gameStates[3].SetActive(true); // GAMEOVER
                gameStates[4].SetActive(false); // GAMEWIN

                break;

            case GameStates.GAMEWIN:
                gameStates[0].SetActive(false); // MENU
                gameStates[1].SetActive(false); // GAME
                gameStates[2].SetActive(false); // PAUSE
                gameStates[3].SetActive(false); // GAMEOVER
                gameStates[4].SetActive(true); // GAMEWIN

                break;

        }


    }


    void Update () {

        if (Input.GetMouseButtonDown(0) && Is_IntroActive == true)
        {
            go_StartButtonIntro.SetActive(true);
            
        }

    }
}
