using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller_level_1 : MonoBehaviour {

    private bool StartScene = false;
    private bool EndScene = false;

    private GameObject[] PrefabForDestr;

    public GameObject[] prefabImage;

    public Animator Window;

    void FixedUpdate () {

            if (gameObject.name == MainController.GetStack())
            {
                if (!StartScene) 
                {
                    StartScene = !StartScene;
                    // запускаем инициализацию
                    InitStart();

                }
            }
            else {

                if (StartScene)
                {
                    if (PrefabForDestr != null )
                    {
                        for (int i = 0; i < PrefabForDestr.Length; i++)
                        {
                            Destroy( PrefabForDestr[i] );
                        }
                    }
                }

                StartScene = false;
            };
	}


    public void InitStart() {
        Debug.Log("Уровень загружен");
        GetRandomDigit();
        GetComponent<AudioSource>().Play();
    }

    public void GetRandomDigit()
    {
        // ширина экрана 
        //float screen_width = GetComponentInParent<Canvas>().pixelRect.width;
        float screen_width = Screen.width;

        //Debug.Log("Ширина экрана:" + screen_width);
        // количество ячеек

        int rand = Random.Range(1, 6);
        //Debug.Log("Рандомное число: "+rand);

        // делим экран на число которое выдал рандом + единица
        // допустим если выпало число 1 то прибавив 1, мы получим 2, затем 
        // разделим на ширину экрана или контейнера в котором будут 
        // размещены объекты и найдем центр по оси Х для размещения объектов
        // 960 = 1920 / 1+1, 960 это координата оси Х для размещения объекта
        float split_cell = screen_width / (rand + 1);

        // создаем массив длиной рандомного числа
        PrefabForDestr = new GameObject[rand];

        for (int a = 0; a < PrefabForDestr.Length; a++) {

            float pos = (a+1) * split_cell;

            GameObject Prefab = Instantiate(prefabImage[a]) as GameObject;

            Prefab.transform.SetParent(gameObject.transform.parent, false);

            Prefab.GetComponent<RectTransform>().position = new Vector2(pos, Prefab.GetComponent<Transform>().position.y);

            PrefabForDestr[a] = Prefab;

        }


    }
}
