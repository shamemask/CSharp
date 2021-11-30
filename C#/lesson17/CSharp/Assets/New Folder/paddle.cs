using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    float height;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        height = gameObject.transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            gameObject.transform.Translate(0, speed, 0);

        }
    }
}
