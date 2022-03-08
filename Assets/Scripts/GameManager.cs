using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IObserver
{
    
    public bool IsFailed { get; set; }
    public bool IsPaused { get; set; }  
    public bool IsWin { get; set; }
    public bool IsGameStarted { get; set; }

    public void OnValueChanged(NotificationType type)
    {
        switch (type)
        {
            case NotificationType.WIN:
                break;
            case NotificationType.FAIL:
                break;
            case NotificationType.PAUSE:
                break;
        }
    }

    private void Awake()
    {
        IsFailed = false;
        IsPaused = false;
        IsWin = false;
        IsGameStarted = false;    
    }

}
