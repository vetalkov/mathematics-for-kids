using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller_close : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;

    public GameObject BackGround;

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp(PointerEventData evenData) {
        GetComponent<AudioSource>().Play();

        BackGround.SetActive(false);
        Window.SetBool("win_show", false);
        Window.SetBool("win_hide", true);
        //MainController.DeleteStack();
    }

 

}
