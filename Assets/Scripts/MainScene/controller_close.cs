using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller_close : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;
    public RuntimeAnimatorController RuntimeAnimatorController;
    public GameObject BackGround;

    public void OnPointerUp(PointerEventData evenData) {
        GetComponent<AudioSource>().Play();
        Window.runtimeAnimatorController = RuntimeAnimatorController;
        BackGround.SetActive(false);

        MainController.DeleteStack();
    }

 
    public void OnPointerDown(PointerEventData evenData)
    {
    }
}
