using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Paddle : MonoBehaviour
{
    [SerializeField] float speed = 2;
    float movementBottom, movementTop;
    // Start is called before the first frame update
    void Start()
    {
        float halfOfHeight = transform.localScale.y / 2;
        float bottomOfTheCamera = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y;
        float topOfTheCamera = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)).y;
        movementBottom = bottomOfTheCamera + halfOfHeight;

        movementTop =  topOfTheCamera - halfOfHeight;
    }

    // Update is called once per frame
    void Update()
    {
        
        float newPosY = transform.position.y + speed * Input.GetAxis("Vertical") * Time.deltaTime;

        newPosY = Mathf.Clamp(newPosY, movementBottom, movementTop);
        transform.position = new Vector2(transform.position.x, newPosY);
    }
}
