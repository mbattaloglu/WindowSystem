using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScreen : Screen, IObserver
{
    public override void DoThingsAtClose()
    {
        Debug.Log("Lose Screen Closed");
    }

    public override void DoThingsAtShow()
    {
        Debug.Log("Win Screen Opened");
    }


    public void OnValueChanged(NotificationType type)
    {
        if (type == NotificationType.FAIL)
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
