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
          //GetStack();
    }

    public static void DeleteStack()
    {
        // удаляем последнее открытое окно
        ActiveWindow.RemoveAt(ActiveWindow.Count - 1);
        //GetStack();
    }

    public static string GetStack()
    {
        return ActiveWindow[ActiveWindow.Count - 1].ToString();
    }

    public bool SetStartAnimation()
    {
        StatusAnimationEnd = true;
        return StatusAnimationEnd;
    }

    public bool SetEndAnimation()
    {
        StatusAnimationEnd = true;
        return StatusAnimationEnd;
    }

}
