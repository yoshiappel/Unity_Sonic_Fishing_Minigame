using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            randomRings.RandomSpawnRing();
            for (int i = 0; i < 12; i++)
            {
                await Task.Delay(200);
                ringQT.transform.localScale += new Vector3(0.05f, 0, 0.05f);

                if ((Input.GetKey(KeyCode.B) && ringQT.transform.localScale.x > 0.3f && ringQT.transform.localScale.x < 0.5f))
                {
                    Debug.Log("1");
                    inputScript.caughtFish = true;
                    ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
                }

            }
        }

        public async void FishQuickTimeEvent2()
        {
            for (int i = 0; i < 18; i++)
            {
                await Task.Delay(200);
                ringQT.transform.localScale -= new Vector3(0.05f, 0, 0.05f);

                if ((Input.GetKey(KeyCode.B) && ringQT.transform.localScale.x > 0.3f && ringQT.transform.localScale.x < 0.5f))
                {
                    Debug.Log("2");
                    inputScript.caughtFish = true;
                    ringQT.transform.localScale = new Vector3(1, 1, 1);
                }

            }
        }

        public async void FishQuickTimeEvent3()
        {
            for (int i = 0; i < 18; i++)
            {
                await Task.Delay(200);
                ringQT.transform.localScale -= new Vector3(0.05f, 0, 0.05f);

                if ((Input.GetKey(KeyCode.B) && ringQT.transform.localScale.x > 0.3f && ringQT.transform.localScale.x < 0.5f))
                {
                    Debug.Log("3");
                    inputScript.caughtFish = true;
                    ringQT.transform.localScale = new Vector3(1, 1, 1);
                }

            }
        }

        private void RevertScale()
        {
            if (ringQT.transform.localScale.x >= 0.7f)
            {
                ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
            }
        }
    }
}
