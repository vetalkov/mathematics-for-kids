﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator Window;

    private bool status;

    public Sprite SpriteDown;
    public Sprite SpriteUp;

    public void OnPointerDown(PointerEventData eventData)
    {
        // вид кнопки когда она нажата
        GetComponent<Image>().sprite = SpriteDown;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // вид кнопки когда она отжата
        GetComponent<Image>().sprite = SpriteUp;

        // проиграть звук нажатия
        GetComponent<AudioSource>().Play();

        MainController.refreshShowWin = false;
        MainController.refreshHideWin = false;

        // записываем в стек
        MainController.AddScene (Window.gameObject.name);

    }

}
