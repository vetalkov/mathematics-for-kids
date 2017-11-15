using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowScenePazl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    // окно которое будет показано
    public Animator Window;

    public void OnPointerDown(PointerEventData pointeventData)
    {
    }

    public void OnPointerUp(PointerEventData pointeventData)
    {
        // проигрываем звук щелчка
        GetComponent<AudioSource>().Play();

        Window.SetBool("win_show", true);
        Window.SetBool("win_hide", false);

        // добавляем в стек новое окно
        //MainController.AddStack(Window.gameObject.name);
    }

}
