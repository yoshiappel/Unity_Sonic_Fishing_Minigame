using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace YA
{
    public class QuickTimeEvent : MonoBehaviour
    {
        // references to other scripts
        [SerializeField] InputScript inputScript;
        [SerializeField] RandomRings randomRings;
        [SerializeField] CubeQTE cubeQTE;

        // vector3
        private Vector3 holderQTScale = new Vector3(0.1f, 0.01f, 0.1f);

        // bools
        public bool Loop;

        //gameObjects
        public GameObject holderQT;

        // this calls every frame
        private void Update()
        {
            // check if it should revert the scale
            RevertScale();
        }

        // on the start of the game
        private void Start()
        {
            // make sure it the right scale when the game starts
            holderQT.transform.localScale = holderQTScale;
        }

        // the QTE for the ring 
        public void FishQuickTimeEvent1()
        {
            // start the coroutine instead of using a while loop
            StartCoroutine(FishQuickTimeEventCoroutine());
        }

        private IEnumerator FishQuickTimeEventCoroutine()
        {
            Loop = true; // set the Loop to true so the while loop works

            // continue scaling while Loop is true
            while (Loop)
            {
                // change the localscale
                holderQT.transform.localScale += new Vector3(0.001f, 0, 0.001f);

                // check if the scale has exceeded limits
                if (holderQT.transform.localScale.x >= 1)
                {
                    // failed to catch the fish
                    inputScript.failedFish = true;
                    Loop = false; // Exit the loop
                }

                yield return null;
            }

            // reset scale
            holderQT.transform.localScale = holderQTScale;
        }

        // revert the scale if needed
        private void RevertScale()
        {
            // if the circle has become to big or the revert bool is true
            if (holderQT.transform.localScale.x >= 1)
            {
                Debug.Log("RevertScale");
                // set FailedFish to true so the cam switches etc
                inputScript.failedFish = true;
                // reset the localscale of rinQT
                holderQT.transform.localScale = holderQTScale;
            }
        }

        // if you quit out of the Application reset the ringQT localScale and set loop to false
        private void OnApplicationQuit()
        {
            holderQT.transform.localScale = holderQTScale;
            Loop = false;
        }
    }
}
