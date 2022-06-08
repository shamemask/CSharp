using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(19.2f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);

        if (transform.position.x < -19.2f)
        {
            transform.position = new Vector2(transform.position.x + 38.4f, 0);
        }
    }
}
