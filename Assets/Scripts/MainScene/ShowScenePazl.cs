using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ShowScenePazl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    private float nextFire = 0.0f;
    private float fireRate = 0.5f;

    // окно которое будет показано
    public Animator Window;

    public void OnPointerDown(PointerEventData pointeventData)
    {
    }

    public void OnPointerUp(PointerEventData pointeventData)
    {
        if (Time.time > nextFire)
        {
            // текущее время плюс частота
            nextFire = Time.time + fireRate;

            // проигрываем звук щелчка
            GetComponent<AudioSource>().Play();

            Window.Play("show_win");

            // добавляем в стек новое окно
            MainController.AddStack(Window.gameObject.name);
        }
    }

}
