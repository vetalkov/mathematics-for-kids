using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator Window;
    private int endAnim = Animator.StringToHash("end");

    public Image Button1;

    public Sprite SpriteDown;
    public Sprite SpriteUp;
    private bool status = true;

    public void OnPointerDown(PointerEventData evenData)
    {
        Button1.GetComponent<Image>().sprite = SpriteDown;
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Button1.GetComponent<Image>().sprite = SpriteUp;

        GetComponent<AudioSource>().Play();

        Window.SetBool("end_anim", true);

    }

    private void Update()
    {
        // информация об анимации на текщем слое Base Layer аниматора
        AnimatorStateInfo stateInfo = Window.GetCurrentAnimatorStateInfo(0);

        // добавляем в стек новое окно
        if (stateInfo.IsName("end"))
        {
            if (status == true)
            {
                status = !status;
                Debug.Log("конец анимации");
            }
        }
    }
}
