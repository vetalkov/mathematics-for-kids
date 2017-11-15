using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonBack : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Animator Window;

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp( PointerEventData evenData )
    {
        Window.SetBool("win_show", false);
        Window.SetBool("win_hide", true);
        GetComponent<AudioSource>().Play();

        //MainController.DeleteStack();
    }
}
