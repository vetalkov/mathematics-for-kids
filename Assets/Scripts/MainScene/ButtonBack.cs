using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ButtonBack : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public Animator Window;
    public RuntimeAnimatorController AnimateControllerShowWindow;

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp( PointerEventData evenData )
    {
        Window.enabled = true;
        Window.runtimeAnimatorController = AnimateControllerShowWindow;
        GetComponent<AudioSource>().Play();

        MainController.DeleteStack();
    }
}
