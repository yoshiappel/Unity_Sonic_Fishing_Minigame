using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace YA
{
    public class QuickTimeEvent : MonoBehaviour
    {
        public GameObject ringQT;

        // references
        public InputScript inputScript;
        public RandomRings randomRings;
        public CubeQTE cubeQTE;
        public bool Loop;


        private void Update()
        {
            RevertScale();
        }

        private void Start()
        {

            // make sure it the right scale
            ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        }
        public async void FishQuickTimeEvent1()
        {
            Loop = true;
            while (Loop)
            {
                await Task.Delay(1);
                ringQT.transform.localScale += new Vector3(0.001f, 0, 0.001f);
            }

        }


        private void RevertScale()
        {
            if (ringQT.transform.localScale.x >= 1 || inputScript.revert)
            {
                ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
                cubeQTE.cubeQTE_OBJ.transform.localPosition = new Vector3(0, 0, 1.24f);
            }
        }

        private void OnApplicationQuit()
        {
            ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
            Loop = false;
        }
    }
}
