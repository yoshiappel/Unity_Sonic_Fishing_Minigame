using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace YA {
    public class InputScript : MonoBehaviour
    {

        // variables
        [SerializeField] Rigidbody ballRigidbody;
        // cameras
        [SerializeField] Camera fishCam;
        [SerializeField] Camera mainCam;

        // gameObjects
        [Header("GameObjects")]
        [SerializeField] GameObject ring;
        public GameObject ball;

        // bools
        [Header("Bools")]
        public bool canFish = true;
        public bool canCast = false;
        public bool canReelIn = false;
        public bool caughtFish = false;
        public bool failedFish = false;
        private bool caughtFishPrompt;

        // reference the other scripts
        [SerializeField] Fish_o_pedia fishOpedia;
        [SerializeField] QuickTimeEvent quickTimeEvent;
        [SerializeField] RandomRings randomRings;
        [SerializeField] CubeTrigger cubeTrigger;
        [SerializeField] UISystem uiSystem;

        // input for actions in the game
        [Header("Input")]
        public KeyCode ReelIn = KeyCode.B;
        public KeyCode Accept = KeyCode.E;


        private void Update()
        {
            CheckInput(); // call this function every frame so it checks for input every frame
        }

        // check the input 
        private void CheckInput()
        {
            // cast the rod
            if (Input.GetKeyDown(KeyCode.F) && canCast)
            {
                uiSystem.OnCastTheLine();
                CastRod();
            }
            // if you complete the QTE so catch the fish
            if (caughtFish)
            {
                FishCaught();
            }
            // if you failed to catch the fish
            if (failedFish)
            {
                FailedFish();
            }
            if (Input.GetKeyDown(Accept) && caughtFishPrompt)
            {
                SetCaughtFishPromptFalse();
            }
        }

        private void SetCaughtFishPromptFalse()
        {
            uiSystem.caughtFishUI.gameObject.SetActive(false);
            uiSystem.menuUI.gameObject.SetActive(true);
            caughtFishPrompt = false;
        }

        public void StartFishing()
        {
            randomRings.RandomSpawnRing(); // set the localscale of the target ring to a random amount
            EnableFishCam(); // enable the right cam (fishcam)
            canCast = true; // make sure you CAN cast the rod 
            canFish = false; // make sure you can't choose to fish twice 
            randomRings.CalculateTargetRing(); // for testing (see logs for the scaling of the targetring)
        }

        private void CastRod()
        {
            randomRings.targetRing.gameObject.SetActive(true);
            quickTimeEvent.holderQT.gameObject.SetActive(true);
            // disable the ring for visual aspect of the game
            ring.gameObject.SetActive(false);
            // make sure you cant cast twice
            canCast = false;
            // start the QTE in QuickTimeEvent Script & the MoveCubeQTE in the CubeQTE script
            quickTimeEvent.FishQuickTimeEvent1();
            //cubeQte.MoveCubeQte(); // this is not needed anymore
        }

        public void FailedFish()
        {
            // setting failedFish to false so you can fail it again ;)
            failedFish = false;
            EnableMainCam(); // enable the right cam (maincam)
            // make sure you can fish again
            canFish = true;
            ResetRings();
        }

        public void FishCaught()
        {
            EnableMainCam(); // enable the right cam (maincam)
            Debug.Log("Fish Caught"); // for testing
            caughtFish = false; // set caughtFish false so this won't go off twice
            canFish = true; // make sure you can fish again
            // call the function in fishcollections
            fishOpedia.RandomFish();
            caughtFishPrompt = true;
            ResetRings();
        }

        private void EnableMainCam()
        {
            Debug.Log("Main camera enabled"); // see debug.log
            fishCam.enabled = false;
            mainCam.enabled = true;
        }

        private void EnableFishCam()
        {
            Debug.Log("Fish camera enabled"); // see debug.log
            fishCam.enabled = true;
            mainCam.enabled = false;
        }

        private void ResetRings()
        {
            ring.gameObject.SetActive(true);
            randomRings.targetRing.gameObject.SetActive(false);
            quickTimeEvent.holderQT.gameObject.SetActive(false);
        }
    }
}
