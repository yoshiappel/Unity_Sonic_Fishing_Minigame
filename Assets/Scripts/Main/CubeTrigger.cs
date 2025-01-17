using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class CubeTrigger : MonoBehaviour
    {
        // references to other scripts
        [SerializeField] InputScript inputScript;
        [SerializeField] QuickTimeEvent QTE;

        // the gameObject that moves towards targetCube
        [SerializeField] GameObject cubeQTE;

        // a function to detect if the trigger in a collider is triggered // so in this case if cubeQTE is inside targetCube
        private void OnTriggerStay(Collider other)
        {
            // if cubeQTE is inside targetCube
            if (other.gameObject.tag == "cubeQTE")
            {
                // if the input ReelIn is pressed the do the following // i made it a variable because the ability to change it in the editor and in the future the settings
                if (Input.GetKey(inputScript.ReelIn) && inputScript.canReelIn)
                {
                    inputScript.canReelIn = false;
                    // first set the Loop in QTE false so the ring/cubes stop moving
                    QTE.Loop = false;
                    // log for testing
                    Debug.Log("catched");
                    // set this bool true so a other function can work in inputscript
                    inputScript.caughtFish = true;
                    // reset the scale of ringQT
                    QTE.ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
                }
            }
        }

    }
}