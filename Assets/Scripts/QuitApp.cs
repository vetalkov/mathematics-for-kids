using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuitApp : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    void Update() {
        /*  if (Input.GetKey(KeyCode.Escape))
          {
              Application.Quit();
          }
          */
        //Debug.Log("Application ending after " + Time.time + " seconds");
    }

    public void OnPointerDown(PointerEventData evenData)
    {
    }

    public void OnPointerUp(PointerEventData evenData)
    {
        //OnApplicationQuit();
    }

    void OnApplicationQuit()
    {
       // Debug.Log("Application ending after " + Time.time + " seconds");
    }
}
