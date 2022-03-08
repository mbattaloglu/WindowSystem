using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, ISubject
{
    public List<IObserver> observers = new List<IObserver>();

    public float speed;
    private Rigidbody rb;

    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.name)
        {
            case "FailCube":
                NotifyObservers(NotificationType.FAIL);
                gameManager.IsFailed = true;
                speed = 0;
                break;
            case "WinCube":
                NotifyObservers(NotificationType.WIN);
                gameManager.IsWin = true;
                break;
        }
    }

    private void Awake()
    {
        //observers = FindObjectsOfType<MonoBehaviour>().OfType<IObserver>().ToList();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if ((!gameManager.IsPaused || !gameManager.IsFailed || gameManager.IsWin) && gameManager.IsGameStarted)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            rb.AddForce(new Vector3(horizontal, 0, vertical) * speed);
        }
    }


    public void NotifyObserver(NotificationType type, IObserver observer)
    {
        observer.OnValueChanged(type);
    }

    public void NotifyObservers(NotificationType type)
    {
        foreach (IObserver observer in observers)
        {
            observer.OnValueChanged(type);
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
}
