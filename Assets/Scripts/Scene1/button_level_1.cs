using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class button_level_1 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp(PointerEventData evenData)
    {

        Window.SetBool("win_show", true);
        Window.SetBool("win_hide", false);

        // загружаем сцену
        //MainController.AddStack(Window.gameObject.name);
    }


}
