using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{
    [SerializeField] float speed = 5;
    float halfOfWidth;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        halfOfWidth = GetComponent<BoxCollider2D>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float newXpos = Mathf.Clamp(transform.position.x + deltaX, gm.BottomLeft.x + halfOfWidth, gm.TopRight.x - halfOfWidth);
        transform.position = new Vector2(newXpos, transform.position.y);
    }
}
