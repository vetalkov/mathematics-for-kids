using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator Window;
    //private int endAnim = Animator.StringToHash("end");

    public Sprite SpriteDown;
    public Sprite SpriteUp;

    private bool status = false;

    public void OnPointerDown(PointerEventData evenData)
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
        
        // устанавливаем переменную end_anim в анимации в true
        // что позволит перейти к следующему состоянию анимации
        Window.SetBool("win_show", true);
        Window.SetBool("win_hide", false);
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
                //MainController.AddStack(Window.gameObject.name);
            }
        }
    }
}
