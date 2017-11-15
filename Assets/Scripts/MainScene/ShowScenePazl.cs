using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowScenePazl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    // окно которое будет показано
    public Animator Window;

    // анимация показа окна
    public RuntimeAnimatorController RuntimeAnimatorController;

    public void OnPointerDown(PointerEventData pointeventData)
    {
    }

    public void OnPointerUp(PointerEventData pointeventData)
    {
        // проигрываем звук щелчка
        GetComponent<AudioSource>().Play();

        // анимация выезда окна
        Window.runtimeAnimatorController = RuntimeAnimatorController;

        // включаем анимацию
        Window.enabled = true;

        // добавляем в стек новое окно
        MainController.AddStack(Window.gameObject.name);
    }

}
