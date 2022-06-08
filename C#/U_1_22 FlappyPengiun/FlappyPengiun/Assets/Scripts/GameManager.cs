using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject columnPrefab;
    public GameObject spacePrefab;
    public GameObject panelGameOver;
    public Text timerText;    
    public Text scoreText;


    public static Vector2 topRight;
    public static Vector2 bottomLeft;

    int time = 0;
    bool isRunGame = true;

    public int speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));

        float s = (float)speed / 100;
        Invoke("SpawnColumn", s);

        StartSpace();
        InvokeRepeating("Timer", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = time.ToString();

        if (!isRunGame)
        {
            Time.timeScale = 0;
            panelGameOver.SetActive(true);
            scoreText.text = "Ваше время: " + time.ToString();
        }
    }

    public void SetPause(bool flag)
    {
        isRunGame = flag;
    }

    void StartSpace()
    {
        GameObject space = Instantiate(spacePrefab) as GameObject;
        space.transform.position = new Vector2(0, 0);

        space = Instantiate(spacePrefab) as GameObject;
        space.transform.position = new Vector2(19.2f, 0);
    }

    void Timer()
    {
        time++;
        //Invoke("Timer", 1);
    }

    void SpawnColumn()
    {        
        GameObject columnTop = Instantiate(columnPrefab) as GameObject;
        columnTop.GetComponent<Column>().isTop = true;        

        GameObject columnBottom = Instantiate(columnPrefab) as GameObject;
        float s = (float)speed / 100;
        Invoke("SpawnColumn", s);
    }
}
