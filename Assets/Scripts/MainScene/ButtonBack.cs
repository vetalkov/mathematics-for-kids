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

        GetComponent<AudioSource>().Play();

        MainController.refreshShowWin = false;
        MainController.refreshHideWin = false;

        MainController.AddScene(Window.gameObject.name);
    }
}


//if (Time.time > nextFire)
//{
// текущее время плюс частота
// nextFire = Time.time + fireRate;
// }

         /*   // если ответили правильно 5 раз подряд
        if (countRound >= 5)
        {
            // показываем сообщение что выиграли
            Debug.Log("Вы прошли тур");

            // сбрасываем счетчик
            countRound = 0;
            StartScene = false;
            MainController.DeleteStack();
            
            // выходим в предыдущее окно
            // Window.Play("hide_win");
            // GetComponent<AudioSource>().Play();
        }
        */
