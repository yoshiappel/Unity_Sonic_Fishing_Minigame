using UnityEngine;

namespace Sonic.Minigame
{
    public class CastLine : MonoBehaviour
    {
        [SerializeField] KeyCode Up = KeyCode.UpArrow;
        [SerializeField] KeyCode Down = KeyCode.DownArrow;
        [SerializeField] KeyCode Left = KeyCode.LeftArrow;
        [SerializeField] KeyCode Right = KeyCode.RightArrow;

        private GameObject ball;
        public bool canCast = false;

        private void Awake()
        {
            ball = this.gameObject;
        }

        private void Update()
        {
            if (canCast)
            {
                Move();
            }
        }

        private void Move()
        {
            if (Input.GetKey(Up))
            {
                ball.transform.position += Vector3.forward * 20f * Time.deltaTime;
            }
            if (Input.GetKey(Left))
            {
                ball.transform.position += Vector3.left * 20f * Time.deltaTime;
            }
            if (Input.GetKey(Down))
            {
                ball.transform.position += Vector3.back * 20f * Time.deltaTime;
            }
            if (Input.GetKey(Right))
            {
                ball.transform.position += Vector3.right * 20f * Time.deltaTime;
            }
        }
    }
}