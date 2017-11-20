using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainController : MonoBehaviour
{

    public Animator WindowSettings;
    public Animator MainWindow;
    public Animator Scene_1;
    public Animator Level_1;
    public Animator ScenePazl;
    public Animator level_1_background;

    /// <summary>
    /// массив служащий стеком открытых окон
    /// </summary>
    private static ArrayList ListScene;

    /// <summary>
    /// переменная refreshShowWin нужна чтобы показать анимацию только один раз для показа окна
    /// </summary>
    public static bool refreshShowWin;

    /// <summary>
    /// переменная refreshHideWin нужна чтобы показать анимацию только один раз для скрытия окна
    /// </summary>
    public static bool refreshHideWin;

    /// <summary>
    /// создаем массив в который будем записывать открытые окна
    /// </summary>
    private void Awake()
    {
        ListScene = new ArrayList();
    }

    public static string curWin;
    public static string preWin;

    /// <summary>
    /// в начале сцены записываем название стартового окно в массив
    /// </summary>
    private void Start()
    {
        AddScene( MainWindow.gameObject.name );
        curWin = MainWindow.gameObject.name;
        preWin = MainWindow.gameObject.name;
    }

    /// <summary>
    /// добавляем в массив
    /// </summary>
    /// <param name="name">имя открытого окна</param>
    public static void AddScene( string name ) {
        ListScene.Add(name);
        curWin = name;
    }

    /// <summary>
    /// удаляем из массива
    /// </summary>
    public static void DeleteScene()
    {
        ListScene.RemoveAt(ListScene.Count - 1);
    }

    /// <summary>
    /// получаем последний элемент массива, оно же текущее окно
    /// </summary>
    /// <returns></returns>
    public static string GetCurrentScene()
    {
        string current = "";

        if (ListScene.Count > 0)
        {
            current = ListScene[ListScene.Count - 1].ToString();
        }

        return current;
    }

    /// <summary>
    /// Возвращает предыдущую сцену
    /// </summary>
    /// <returns></returns>
    public static string GetPreviousScene()
    {
        //Debug.Log("размер массива :"+ListScene.Count);
        string pre = "";

        if (ListScene.Count > 1)
        {
            pre = ListScene[ListScene.Count - 2].ToString();
        }

        return pre;
    }

    /// <summary>
    /// получаем колличество элементов в массиве
    /// </summary>
    /// <returns></returns>
    public static int GetCountScene()
    {
        return ListScene.Count;
    }

    /// <summary>
    /// Центр управления окнами
    /// </summary>
    private void Update()
    {
        Debug.Log("Текущая сцена: " + GetCurrentScene() );
        Debug.Log("Предыдущая сцена: " + GetPreviousScene());

        switch (GetPreviousScene())
        {
            case "MainScene":
                if (!refreshHideWin)
                {
                    refreshHideWin = !refreshHideWin;
                    MainWindow.Play("hide_win");
                }
                break;

            case "Scene_1":
                if (!refreshHideWin)
                {
                    refreshHideWin = !refreshHideWin;
                    Scene_1.Play("hide_win");
                }
                break;

            case "Level_1":
                if (!refreshHideWin)
                {
                    refreshHideWin = !refreshHideWin;
                    Level_1.Play("hide_win");
                }
                break;

            case "ScenePazl":
                if (!refreshHideWin)
                {
                    refreshHideWin = !refreshHideWin;
                    ScenePazl.Play("hide_win");
                }
                break;
        }



        switch (GetCurrentScene()) {
            case "MainScene":
                if (!refreshShowWin)
                {
                    refreshShowWin = !refreshShowWin;
                    MainWindow.Play("show_win");
                }
            break;

            case "Scene_1":
                if (!refreshShowWin)
                {
                    refreshShowWin = !refreshShowWin;
                    Scene_1.Play("show_win");
                }
                break;

            case "Level_1":
                if (!refreshShowWin)
                {
                    refreshShowWin = !refreshShowWin;
                    Level_1.Play("show_win");
                }
                break;

            case "ScenePazl":
                if (!refreshShowWin)
                {
                    refreshShowWin = !refreshShowWin;
                    ScenePazl.Play("show_win");
                }
                break;

            default:
                if (!refreshShowWin)
                {
                    refreshShowWin = !refreshShowWin;
                    MainWindow.Play("show_win");
                }
                break;
        }


        
    }
}
