using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Screen : MonoBehaviour
{

    public ScreenManager screenManager { get; set; }
    public abstract void DoThingsAtShow();
    public abstract void DoThingsAtClose();


    private void Awake()
    {
        screenManager = FindObjectOfType<ScreenManager>();
    }

    public void ShowScreen()
    {
        gameObject.SetActive(true);
    }

    public void CloseScreen()
    {
        gameObject.SetActive(false);
    }

    public void QuitOnClick()
    {
        Application.Quit();
    }
}
