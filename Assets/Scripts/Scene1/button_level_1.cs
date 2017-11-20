using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class button_level_1 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;

    private float nextFire = 0.0f;
    private float fireRate = 0.5f;

    private bool start_load;

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (Time.time > nextFire)
        {
            //текущее время плюс частота
            nextFire = Time.time + fireRate;
            
            //проиграть звук нажатия
            GetComponent<AudioSource>().Play();

            Window.SetBool("end_status", true);
            Window.Play("show_win");

            start_load = false;
        }
    }

    private void Update()
    {
        
        // информация об анимации на текщем слое Base Layer аниматора
        AnimatorStateInfo stateInfo = Window.GetCurrentAnimatorStateInfo(0);
        
        if (stateInfo.IsName("end"))
        {
            if (!start_load)
            {
                start_load = !start_load;

                MainController.refreshShowWin = false;
                MainController.refreshHideWin = false;

                // записываем в стек
                MainController.AddScene(Window.gameObject.name);
            }
        }
    }
}
