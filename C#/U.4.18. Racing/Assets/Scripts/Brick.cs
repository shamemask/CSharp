using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    
    [SerializeField] Transform topBorder;
    [SerializeField] float speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("BottomBorder"))
        {
            transform.position = topBorder.position;
        }
    }
}
