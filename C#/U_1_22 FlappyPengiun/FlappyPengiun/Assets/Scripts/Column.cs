using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public bool isTop = false;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = new Vector2(0, 0); //вектор появления
        float x = GameManager.topRight.x + transform.localScale.x / 2; //позиция х всегда таже
        if (isTop) {
            float y = GameManager.topRight.y - transform.localScale.y / 2 + Random.Range(.5f, 3); //добавляем рандом для y
            pos = new Vector2(x, y); //создаем позицию
        }
        else
        {
            float y = GameManager.bottomLeft.y + transform.localScale.y / 2 - Random.Range(.5f, 3);
            pos = new Vector2(x, y); //создаем позицию
            gameObject.GetComponent<SpriteRenderer>().flipY = true; //переворачиваем спрайт
        }

        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > GameManager.bottomLeft.x - transform.localScale.x)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
