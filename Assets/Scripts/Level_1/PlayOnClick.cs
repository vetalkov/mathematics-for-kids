using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayOnClick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public AudioClip aClip;

    public void OnPointerDown(PointerEventData evenData)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (!audio.isPlaying)
        {
            audio.clip = aClip;
            audio.Play();
        }
    }

    public void OnPointerUp(PointerEventData evenData)
    {
    }

}
