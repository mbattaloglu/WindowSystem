using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : Screen, IObserver
{
    public override void DoThingsAtClose()
    {
        Debug.Log("Win Screen Closed");
    }

    public override void DoThingsAtShow()
    {
        Debug.Log("Win Screen Opened");
    }


    public void OnValueChanged(NotificationType type)
    {
        if (type == NotificationType.WIN)
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
