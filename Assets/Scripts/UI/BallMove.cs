using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private float speed = 20f;
    public GameObject ball;
    public InputScript script;

    

    void Update()
    {
        if (script.canfish == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * speed * Time.deltaTime;
            }
        }

    }
}
