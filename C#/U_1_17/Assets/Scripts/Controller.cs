using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("первый запуск");
        //print(gameObject.transform.localScale);
        //print(transform.localScale.x);
        //print(transform.localScale.y);
        //print(transform.localScale.z);

        Vector3 scale = new Vector3(10, 10, 1);
        transform.localScale = scale;

        Vector3 position = new Vector3(0, 0, 0);
        transform.position = position;

        Vector3 rotation = new Vector3(0, 0, 45);
        transform.rotation = Quaternion.Euler(rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //print("я работаю всегда!");
        float currentZ = transform.rotation.eulerAngles.z;
        Vector3 rotation = new Vector3(0, 0, currentZ + 0.1f);
        transform.rotation = Quaternion.Euler(rotation);
    }
}
