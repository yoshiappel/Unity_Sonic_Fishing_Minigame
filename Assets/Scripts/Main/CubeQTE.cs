using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace YA
{
    public class CubeQTE : MonoBehaviour
    {
        public GameObject cubeQTE_OBJ;
        public QuickTimeEvent QTE;
        public InputScript inputScript;

        private void Start()
        {

        }


        private void Update()
        {

        }

        public async void MoveCubeQte()
        {
            while (QTE.Loop)
            {
                await Task.Delay(1);
                cubeQTE_OBJ.transform.position += new Vector3(0, 0, 0.012f);
            }
        }

    }
}