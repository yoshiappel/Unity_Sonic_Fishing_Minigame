using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class BallMove : MonoBehaviour
    {
        // how fast the ball moves
        private float speed = 20f;

        [Header("Assign these variables")]
        public GameObject ball;
        public InputScript inputScript;



        private void Update()
        {
            MoveObject();
        }

        // moves the ball using WASD
        private void MoveObject()
        {
            if (inputScript.canCast == true)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    ball.transform.position += Vector3.right * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.A))
                {
                    ball.transform.position += Vector3.left * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.W))
                {
                    ball.transform.position += Vector3.forward * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    ball.transform.position += Vector3.back * speed * Time.deltaTime;
                }
            }
        }
    }
}
