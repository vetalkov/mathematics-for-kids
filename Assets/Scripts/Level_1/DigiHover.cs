using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DigiHover : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    private string digit;

    public AudioClip NoPravilno;
    public AudioClip Pravilno;
    private AudioSource otvet;
    public Animator Window;

    void Start() {
        otvet = GetComponent<AudioSource>();
    }

    public void OnPointerDown( PointerEventData eventData)
    {
        digit = gameObject.tag;
        switch (controller_level_1.rand) {
           
            case 1:
                if (digit == "Dig1")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 2:
                if (digit == "Dig2")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 3:
                if (digit == "Dig3")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 4:
                if (digit == "Dig4")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 5:
                if (digit == "Dig5")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 6:
                if (digit == "Dig6")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 7:
                if (digit == "Dig7")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 8:
                if (digit == "Dig8")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            case 9:
                if (digit == "Dig9")
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(Pravilno);
                        StartCoroutine(controller_level_1.ReloadLevel());
                    }
                }
                else
                {
                    if (!otvet.isPlaying)
                    {
                        otvet.PlayOneShot(NoPravilno);
                    }
                }
                break;

            default:
                if (!otvet.isPlaying)
                {
                    otvet.PlayOneShot(NoPravilno);
                }
                break;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }

    public void CheckAnswer() {
        // если ответили правильно 5 раз подряд
        if (controller_level_1.countRound >= 5)
        {
            // показываем сообщение что выиграли
            Debug.Log("Вы прошли тур");

            // сбрасываем счетчик
            controller_level_1.countRound = 0;
            controller_level_1.StartScene = false;
            MainController.DeleteStack();
        }
    }

}
