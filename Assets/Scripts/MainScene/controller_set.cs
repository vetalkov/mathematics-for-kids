using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller_set : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public Animator Window;
    public RuntimeAnimatorController RuntimeAnimatorController;

    public GameObject BackGround;
    public Sprite down_button;
    public Sprite up_button;

    public void OnPointerDown(PointerEventData evenData)
    {
        GetComponent<Image>().sprite = down_button;
    }

    public void OnPointerUp(PointerEventData evenData)
    {

        GetComponent<Image>().sprite = up_button;

        // проигрываем звук щелчка
        GetComponent<AudioSource>().Play();

        // загружаем контроллер анимации
        Window.runtimeAnimatorController = RuntimeAnimatorController;

        // включаем анимацию
        Window.enabled = true;

        // затеняем фон и делаем его не активным
        BackGround.SetActive(true);

        MainController.AddStack(Window.gameObject.name);
    }




}
