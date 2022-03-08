using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public Transform screens;

    public MenuScreen menuScreen;
    public GameScreen gameScreen;
    public PauseScreen pauseScreen;
    public WinScreen winScreen;
    public LoseScreen loseScreen;

    public GameManager gameManager;
    public PlayerController playerController;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        playerController = FindObjectOfType<PlayerController>();
    }
    private void Start()
    {
        //THAT SHOULD BE IMPROVED
        playerController.observers.Add(menuScreen);
        playerController.observers.Add(pauseScreen);
        playerController.observers.Add(winScreen);
        playerController.observers.Add(gameScreen);
        playerController.observers.Add(loseScreen);
        playerController.observers.Add(gameManager);

        for (int i = 0; i < screens.childCount; i++)
        {
            screens.GetChild(i).gameObject.SetActive(false);    
        }
        
        //Activate Menu Screen
        screens.GetChild(0).gameObject.SetActive(true);
    }
}
