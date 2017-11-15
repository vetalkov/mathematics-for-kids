using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class button_level_1 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;

    private bool status = false;

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp(PointerEventData evenData)
    {
        // проиграть звук нажатия
        GetComponent<AudioSource>().Play();

        Window.SetBool("win_show", true);
        Window.SetBool("win_hide", false);

        // загружаем сцену
        // MainController.AddStack(Window.gameObject.name);
    }

    private void Update()
    {
        // информация об анимации на текщем слое Base Layer аниматора
        AnimatorStateInfo stateInfo = Window.GetCurrentAnimatorStateInfo(0);

        // если состояние анимации "end" то выполняем какие-то действия
        if (stateInfo.IsName("end"))
        {
            if (status == false)
            {
                status = !status;
                Debug.Log("конец анимации маин сцена");
                MainController.AddStack(Window.gameObject.name);
            }
        }
    }

}
