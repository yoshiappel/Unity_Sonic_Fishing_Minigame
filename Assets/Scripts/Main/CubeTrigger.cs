using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class CubeTrigger : MonoBehaviour
    {
        // References to other scripts
        [SerializeField] private InputScript inputScript;
        [SerializeField] private QuickTimeEvent QTE;
        [SerializeField] UISystem uiSystem;

        // The GameObject that moves towards targetCube
        [SerializeField] private GameObject cubeQTE;

        private void OnTriggerEnter(Collider other)
        {
            // Check if the moving cube is inside the target cube
            if (other.CompareTag("cubeQTE"))
            {
                inputScript.canReelIn = true; // Allow reeling in
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("cubeQTE"))
            {
                inputScript.canReelIn = false; // Disable reeling in on exit
            }
        }

        private void Update()
        {
            // Handle input for reeling in
            if (Input.GetKeyDown(inputScript.ReelIn))
            {
                if (inputScript.canReelIn) // Successful catch
                {
                    CatchFish();
                    uiSystem.OnHookTheFish();
                }
                else if (!inputScript.caughtFish) // Failed attempt
                {
                    FailFish();
                    uiSystem.OnHookTheFish();
                }
            }
        }

        private void CatchFish()
        {
            inputScript.canReelIn = false;
            inputScript.caughtFish = true;

            // Stop the QTE loop
            QTE.Loop = false;

            // Reset the ring scale
            QTE.holderQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);

            Debug.Log("Caught the fish!");
        }

        private void FailFish()
        {
            inputScript.failedFish = true;

            // Stop the QTE loop
            QTE.Loop = false;

            Debug.Log("Failed to catch the fish!");
        }
    }
}
