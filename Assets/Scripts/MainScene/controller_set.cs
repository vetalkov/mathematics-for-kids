using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller_set : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public Animator Window;

    public GameObject BackGround;
    public Sprite down_button;
    public Sprite up_button;

    private float nextFire = 0.0f;
    private float fireRate = 0.5f;

    public void OnPointerDown(PointerEventData evenData)
    {
        GetComponent<Image>().sprite = down_button;
    }

    public void OnPointerUp(PointerEventData evenData)
    {
        if (Time.time > nextFire)
        {
            // текущее время плюс частота
            nextFire = Time.time + fireRate;

            GetComponent<Image>().sprite = up_button;

            // проигрываем звук щелчка
            GetComponent<AudioSource>().Play();

            Window.SetBool("win_show", true);
            Window.SetBool("win_hide", false);

            // затеняем фон и делаем его не активным
            BackGround.SetActive(true);

            MainController.AddScene(Window.gameObject.name);
        }
    }
    

}
