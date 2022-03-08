using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : Screen, IObserver
{
    public override void DoThingsAtClose()
    {
        Debug.Log("Pause Screen Closed");
    }

    public override void DoThingsAtShow()
    {
        Debug.Log("Pause Screen Opened");
    }

    public void ContinueOnClick()
    {
        CloseScreen();
        screenManager.gameScreen.ShowScreen();
        screenManager.gameManager.IsPaused = false;
    }
    public void OnValueChanged(NotificationType type)
    {
        if (type == NotificationType.PAUSE)
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
