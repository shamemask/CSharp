using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("первый запуск");

        print(gameObject.transform.localScale);

        print(transform.localScale.x);

        print(transform.localScale.y);

        print(transform.localScale.z);
        Vector3 vector3 = new Vector3(10, 10, 1);

        transform.localScale = vector3;
        vector3 = new Vector3(0, 0, 45);

        transform.rotation = Quaternion.Euler(vector3);
        vector3 = new Vector3(-3, 0, 0);

        transform.position = vector3;
    }

    // Update is called once per frame
    void Update()
    {
        //print("я работаю всегда!");
        float z = transform.rotation.eulerAngles.z;

        Vector3 v3 = new Vector3(0, 0, z + 0.1f);

        transform.rotation = Quaternion.Euler(v3);

        float x = transform.position.x;

        Vector3 v = new Vector3(x + 0.001f, 0, 0);

        transform.position = v;
    }
}
