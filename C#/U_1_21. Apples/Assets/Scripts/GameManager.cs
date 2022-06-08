using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Vector2 bottomLeft, topRight;
    [SerializeField] GameObject applePrefab;

    [SerializeField] int lives, score;
    [SerializeField] Text livesText, scoreText;

    public int Lives
    {
        get { return lives; }
        set
        {
            lives = value;
            livesText.text = $"Æèçíè: {lives}";
            if (lives < 1) Time.timeScale = 0;
        }
    }

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreText.text = $"Ñ÷¸ò: {score}";
        }
    }

    public Vector2 TopRight { get { return topRight; } }
    public Vector2 BottomLeft { get { return bottomLeft; } }
    // Start is called before the first frame update
    void Start()
    {
        bottomLeft = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        InvokeRepeating(nameof(CreateApple), 2f, 1.5f);
        Lives = lives;
        Score = score;
    }

    void CreateApple()
    {
        GameObject apple = Instantiate(applePrefab);
        Vector2 position = new Vector2(Random.Range(bottomLeft.x, topRight.x), topRight.y);
        apple.transform.position = position;
    }
}
