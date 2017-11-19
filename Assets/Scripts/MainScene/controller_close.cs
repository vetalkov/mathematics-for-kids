using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller_close : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;

    public GameObject BackGround;

    private float nextFire = 0.0f;
    private float fireRate = 0.5f;

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp(PointerEventData evenData) {
        if (Time.time > nextFire)
        {
            // текущее время плюс частота
            nextFire = Time.time + fireRate;

            GetComponent<AudioSource>().Play();

            BackGround.SetActive(false);
            Window.SetBool("win_show", false);
            Window.SetBool("win_hide", true);
            MainController.DeleteStack();
        }
    }

 

}
