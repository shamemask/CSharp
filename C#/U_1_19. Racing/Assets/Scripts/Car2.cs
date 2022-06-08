using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    [SerializeField] float speed = 10;

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //transform.Translate(speed * horizontal * Time.deltaTime, 0, 0);
        Control();

    }
    void Control()
    {
        float xm = 0, ym = 0, zm = 0;

        //if (Input.GetKey(KeyCode.W))
        //{
        //    zm += m_movSpeed * Time.deltaTime;
        //}
        //else if (Input.GetKey(KeyCode.S)) // ������� ������� S, ����� ������������� ����
        //{
        //    zm -= m_movSpeed * Time.deltaTime;
        //}

        if (Input.GetKey(KeyCode.A)) // ������� ���������� A ��� ����������� �����
        {
            xm -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D)) // ������� ������� D, ����� ������������� ������
        {
            xm += speed * Time.deltaTime;
        }
        //transform.Translate(new Vector3(xm, ym, zm), Space.Self);
        transform.Translate(xm, 0, 0);

    }

}
