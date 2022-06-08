using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    int index = 0;
    SpriteRenderer spriteRenderer;
    Car car;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        car = FindObjectOfType<Car>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!car.Driving) return;
        index = index == 0 ? 1 : 0;
        spriteRenderer.sprite = sprites[index];



    }
}
