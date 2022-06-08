using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    
    [SerializeField] Transform topBorder;
    [SerializeField] Transform leftBorder, rightBorder;
    [SerializeField] float speed = 7, sizeX;
    // Start is called before the first frame update
    void Start()
    {
        sizeX = GetComponent<BoxCollider2D>().size.x / 2;
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
            float x = Random.Range(
                leftBorder.transform.position.x + sizeX, 
                rightBorder.transform.position.x - sizeX);
            //transform.position = topBorder.position;
            Vector2 newPos = new Vector2(
                x, 
                topBorder.position.y);
            transform.position = newPos;
        }
    }
}
