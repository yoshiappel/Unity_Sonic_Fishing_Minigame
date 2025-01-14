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

            for (int i = 0; i < 14; i++)
            {
                await Task.Delay(200);
                ringQT.transform.localScale += new Vector3(0.05f, 0, 0.05f);
 
            }

        }


        private void RevertScale()
        {
            if (ringQT.transform.localScale.x >= 1 || inputScript.revert)
            {
                ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
            }
        }
    }
}
