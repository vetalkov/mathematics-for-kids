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
            Window.Play("hide_win");
            GetComponent<AudioSource>().Play();

            MainController.DeleteStack();
    }
}


//if (Time.time > nextFire)
//{
// текущее время плюс частота
// nextFire = Time.time + fireRate;
// }