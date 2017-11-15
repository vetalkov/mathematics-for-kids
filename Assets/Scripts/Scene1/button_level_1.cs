using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class button_level_1 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;

    public int showHash = Animator.StringToHash("idle");

    //public RuntimeAnimatorController AnimateControllerShowWindow;

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp(PointerEventData evenData)
    {
        // запускаем проигрывание анимации
        //Window.runtimeAnimatorController = AnimateControllerShowWindow;
        //Window.enabled = true;

        Debug.Log(showHash);

        Window.SetBool(showHash, true);

        // загружаем сцену
        MainController.AddStack(Window.gameObject.name);
    }


}
