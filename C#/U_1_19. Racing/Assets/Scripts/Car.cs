using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float speed = 10;
    bool driving = true;
    // Update is called once per frame
    [SerializeField] Transform go;
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //transform.Translate(speed * horizontal * Time.deltaTime, 0, 0);
        Control();

    }
    public bool Driving
    {

        get { return driving; }
        set
        {

            driving = value;

            if (!driving) Time.timeScale = 0;

        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Brick"))
            
        go.transform.SetPositionAndRotation(new Vector3(go.transform.position.x, go.transform.position.y, -3), transform.rotation);
        
        Driving = false;

    }
    void Control()
    {
        float xm = 0, ym = 0, zm = 0;

        //if (Input.GetKey(KeyCode.W))
        //{
        //    zm += m_movSpeed * Time.deltaTime;
        //}
        //else if (Input.GetKey(KeyCode.S)) // Нажмите клавишу S, чтобы переместиться вниз
        //{
        //    zm -= m_movSpeed * Time.deltaTime;
        //}

        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            xm -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            xm += speed * Time.deltaTime;
        }
         transform.Translate(xm, 0, 0);

    }
}
