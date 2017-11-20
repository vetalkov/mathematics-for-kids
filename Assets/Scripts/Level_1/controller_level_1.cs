using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controller_level_1 : MonoBehaviour {

    public static bool StartScene;

    private static GameObject[] PrefabForDestr;
    private static GameObject[] PrefabForDestrDigi;
    

    public GameObject[] prefabImage;
    public GameObject[] prefabDigi;

    public Animator Window;

    public static int rand;
    public static int countRound;

    private void Awake()
    {
        countRound = 0;
        rand = 0;
    }

     private void Update () {

            if (MainController.GetCurrentScene() == Window.gameObject.name)
            {
                if (!StartScene) 
                {
                    StartScene = !StartScene;
                    // запускаем инициализацию
                    GenerateLevel();
                }
            }
            else {

                if (StartScene)
                {
                    // останавливаем звук
                    GetComponent<AudioSource>().Stop();
                    
                    // если массив объектов не пуст, то удаляем его содержимое
                    if (PrefabForDestr != null )
                    {
                        for (int i = 0; i < PrefabForDestr.Length; i++)
                        {
                            Destroy( PrefabForDestr[i] );
                        }
                    }

                    if (PrefabForDestrDigi != null)
                    {
                        for (int i = 0; i < PrefabForDestrDigi.Length; i++)
                        {
                            Destroy(PrefabForDestrDigi[i]);
                        }
                    }

                
                }

                StartScene = false;
            };

	}


    // перезагрузка уровня
    public static IEnumerator ReloadLevel()
    {

        // анимация если правильно солнышко улыбается
        // иначе прячется за тучку

        yield return new WaitForSeconds(0.5f);

        countRound++;

        Debug.Log("Ответ номер: " + countRound);

        StartScene = false;

        // если массив объектов не пуст, то удаляем его содержимое
        if (PrefabForDestr != null)
        {
            for (int i = 0; i < PrefabForDestr.Length; i++)
            {
                Destroy(PrefabForDestr[i]);
            }
        }

        if (PrefabForDestrDigi != null)
        {
            for (int i = 0; i < PrefabForDestrDigi.Length; i++)
            {
                Destroy(PrefabForDestrDigi[i]);
            }
        }
    }



    /// <summary>
    /// расставляем объекты на канвасе
    /// </summary>
    public void GenerateLevel()
    {
        // ширина экрана 
        float screen_width = Screen.width;

        // количество объектов
        rand = Random.Range(1, 6);

        // делим экран на число которое выдал рандом + единица
        // допустим если выпало число 1 то прибавив 1, мы получим 2, затем 
        // разделим на ширину экрана или контейнера в котором будут 
        // размещены объекты и найдем центр по оси Х для размещения объектов
        // 960 = 1920 / 1+1, 960 это координата оси Х для размещения объекта
        float split_cell = screen_width / (rand + 1);

        // создаем массив длиной рандомного числа
        PrefabForDestr = new GameObject[rand];

        // создаем префабы
        // если переменная "а" меньше количества префабов - создаем их
        for (int a = 0; a < PrefabForDestr.Length; a++) {

            float pos = (a + 1) * split_cell;

            GameObject Prefab = Instantiate(prefabImage[a]);

            // задаем префабу родителя
            Prefab.transform.SetParent(Window.gameObject.transform, false);

            Prefab.GetComponent<RectTransform>().position = new Vector2(pos, Window.GetComponent<RectTransform>().position.y);

            PrefabForDestr[a] = Prefab;

        }

        // генерируем показ цифр
        PrefabForDestrDigi = new GameObject[4];
        float split_cell_digi = screen_width / (PrefabForDestrDigi.Length + 1);

        // получаем массив чисел размером 4 ячейки 
        // значения которых от 1 до 9 с обязательным вхождением rand
        ArrayList mas = GetUniqueRandomDigit(9, rand);

        for (int a = 0; a < PrefabForDestrDigi.Length; a++)
        {

            float pos = (a + 1) * split_cell_digi;

            //ArrayList mas = GetUniqueRandomDigit(9, 1);
            //int item = mas[a];
            // получаем рандомное число от 0 до 5 не включительно
            //int randDigi = Random.Range(0, 5);

            int d = (int) mas[a] ;

            // клонируем префабы
            GameObject PrefabDigi = Instantiate(prefabDigi[d-1]);

            // задаем префабу родителя
            PrefabDigi.transform.SetParent(Window.gameObject.transform, false);

            // размещаем префабы на экране
            PrefabDigi.GetComponent<RectTransform>().position = new Vector2(pos, Window.GetComponent<RectTransform>().position.y - 300);

            // ссылки на префабы записываем в массив
            PrefabForDestrDigi[a] = PrefabDigi;

        }

        
        /*int posItem = 0;
        foreach (int i in mas) {
            Debug.Log("позиция в массиве:"+ posItem + " значение: "+i);
            posItem++;
        }*/

        GetComponent<AudioSource>().Play();
        Window.SetBool("end_status", false);

    }
    /// <summary>
    /// возвращает массив чисел размером 4 ячейки, значения которых от 1 до 9 с обязательным вхождением necessarily
    /// </summary>
    /// <param name="len">количество значенией </param>
    /// <param name="necessarily">значение которое обязательно должно быть</param>
    /// <returns></returns>
    private ArrayList GetUniqueRandomDigit(int len, int necessarily)
    {
        // создаем массивы определенной длинны
        ArrayList initCol = new ArrayList(len);
        
        // массив цифр для выбора ответа
        ArrayList CloneMass = new ArrayList(4);
        
        // наполняем массив числами по опрядку от единицы
        for (int i = 0; i < len; i++) {
            initCol.Add(i+1);
        }

        // пока размер массива больше нуля
        while (initCol.Count > 0) {

            // выбираем случайный номер индекса массива
            int indexRand = Random.Range(0, initCol.Count);

            // копируем содержимое исходного массива в копируемый массив
            if (CloneMass.Count < 4)
            {
                CloneMass.Add(initCol[indexRand]);
            }

            // удаляем елемент массива
            initCol.RemoveAt(indexRand);

        }

        bool find_true_result = false;

        foreach (int k in CloneMass) {
            // если правильный ответ присутвует в массиве
            if (k == necessarily)
            {
                // ставим флаг, что он там есть
                find_true_result = true;
            }
        }
       
        // если правильного ответа нет в массиве то вставляем его туда
        // в рандомную позицию
        if (!find_true_result) {
            int randomPosition = Random.Range(0, 4);
            CloneMass.RemoveAt(randomPosition);
            CloneMass.Insert(randomPosition, necessarily);
        };
        return CloneMass;
    }



}

