using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : Screen, IObserver
{
    public override void DoThingsAtClose()
    {
        Debug.Log("Game Screen Closed");
    }

    public override void DoThingsAtShow()
    {
        
        Debug.Log("Game Screen Opened");
    }

    public void PauseOnClick()
    {
        CloseScreen();
        screenManager.pauseScreen.ShowScreen();
        screenManager.gameManager.IsPaused = true;
    }
    public void OnValueChanged(NotificationType type)
    {
        if (type == NotificationType.ACTIVE_GAME)
        {
            ShowScreen();
            DoThingsAtShow();
        }

        else
        {
            CloseScreen();
            DoThingsAtClose();
        }
    }
}
