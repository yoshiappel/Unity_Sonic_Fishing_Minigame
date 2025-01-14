using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace YA
{
    public class CubeQTE : MonoBehaviour
    {
        private void Start()
        {

        }

        public async void MoveCubeQte()
        {
            for (int i = 0; i < 6; i++)
            {
                await Task.Delay(200);
                transform.position += new Vector3(0, 0, 0.75f);
            }
        }
    }
}