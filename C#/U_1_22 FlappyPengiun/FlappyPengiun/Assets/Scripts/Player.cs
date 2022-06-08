using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;

    public float speed = 5;
    public float speedRotate = 50f;

    float z = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y < GameManager.topRight.y)
                transform.Translate(0, speed * Time.deltaTime, 0, UnityEngine.Space.World);
            GetComponent<Animator>().SetBool("isUp", true);

            if (z <= 20f)
            {
                z += Time.deltaTime * speedRotate;
                transform.rotation = Quaternion.Euler(0, 0, z);
            }
        }
        else
        {
            if (transform.position.y > GameManager.bottomLeft.y)
                transform.Translate(0, -speed * Time.deltaTime, 0, UnityEngine.Space.World);
            GetComponent<Animator>().SetBool("isUp", false);

            if (z >= -20f)
            {
                z -= Time.deltaTime * speedRotate;
                transform.rotation = Quaternion.Euler(0, 0, z);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Column"))
        {
            //Debug.Log("Collision");


            gameManager.SetPause(false);
        }
    }
}
