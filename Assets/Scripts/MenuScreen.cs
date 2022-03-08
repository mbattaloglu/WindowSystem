using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : Screen, IObserver
{
    public override void DoThingsAtClose()
    {
        Debug.Log("Menu Screen Closed");
    }

    public override void DoThingsAtShow()
    {
        Debug.Log("Menu Screen Opened");
    }

    public void PlayOnClick()
    {
        CloseScreen();
        screenManager.gameManager.IsGameStarted = true;
        screenManager.gameScreen.ShowScreen();
    }


    public void OnValueChanged(NotificationType type)
    {
        if (type == NotificationType.MENU)
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
