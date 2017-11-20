using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainController : MonoBehaviour
{

    public Animator WindowSettings;
    public Animator Scene1;
    public Animator ScenePazl;
    public Animator level_1_background;
    public Animator MainWindow;

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
        AddStack(MainWindow.gameObject.name);
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

    public static bool refreshWin;



    private void Update()
    {
        Debug.Log(GetStack());
        switch (GetStack()) {
            case "MainScene":
                if (!refreshWin)
                {
                    refreshWin = !refreshWin;
                    MainWindow.Play("show_win");
                }
            break;

            case "Scene_1":
                if (!refreshWin)
                {
                    refreshWin = !refreshWin;
                    Scene1.Play("show_win");
                }
                break;

        }
    }
}
