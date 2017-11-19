using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainController : MonoBehaviour
{

    public Animator WindowSettings;
    public Animator Scene1;
    public Animator ScenePazl;
    public Animator level_1_background;
    public static ArrayList ActiveWindow;

    public static bool StatusAnimationEnd;

    private void Awake()
    {
        // создаем массив в который будем записывать открытые окна
        ActiveWindow = new ArrayList();
    }

    private void Start()
    {
        // записываем текущее окно в стек
        AddStack(gameObject.name);
    }

    public static void AddStack(string name) {
          ActiveWindow.Add(name);
    }

    public static void DeleteStack()
    {
        // удаляем последнее открытое окно
        ActiveWindow.RemoveAt(ActiveWindow.Count - 1);
    }

    public static string GetStack()
    {
        if (ActiveWindow.Count > 0)
        {
            return ActiveWindow[ActiveWindow.Count - 1].ToString();
        }
        else {
            return "";
        }
    }

    public static int GetStackCount()
    {
        return ActiveWindow.Count;
    }


    private void Update()
    {
       
    }
}
