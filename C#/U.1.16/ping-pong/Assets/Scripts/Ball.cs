using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speedX = 5, speedY = 5;
    void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.name.Equals("RightBorder"))

        {

            Time.timeScale = 0;

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speedX, speedY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
