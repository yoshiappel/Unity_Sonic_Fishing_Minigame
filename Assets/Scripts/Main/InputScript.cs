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
        public bool revert = false;

        // text variables
        [Header("Text")]
        [SerializeField] TMP_Text testText1;
        public TMP_Text testText2;

        // reference the other scripts
        public FishCollection fishCollection;
        public QuickTimeEvent quickTimeEvent;
        public RandomRings randomRings;
        public CubeQTE cubeQte;

        // input for actions in the game
        [Header("Input")]
        public KeyCode ReelIn = KeyCode.B;


        // every frame
        private void Update()
        {
            // calls this function every frame so it checks for input every frame
            CheckInput();
        }

        // check the input 
        private void CheckInput()
        {
            // if F and canCast == true
            if (Input.GetKeyDown(KeyCode.F) && canFish)
            {
                //randomRings.RandomSpawnRing();
                testText1.enabled = false;
                fishCam.enabled = true;
                mainCam.enabled = false;
                // make sure you CAN cast the rod 
                canCast = true;
                // make sure you can't choose to fish twice 
                canFish = false;

                //randomRings.CalculateTargetRing();
            }
            // cast the rod
            // if G and canFish == true
            if (Input.GetKeyDown(KeyCode.G) && canCast)
            {
                // this is for testing
                ring.gameObject.SetActive(false);
                // make sure you cant cast twice
                canCast = false;
                // start the QTE in QuickTimeEvent Script & the MoveCubeQTE in the CubeQTE script
                quickTimeEvent.FishQuickTimeEvent1();
                cubeQte.MoveCubeQte();

            }
            // if this is true (its only true if you complete the QTE)
            if (caughtFish)
            {
                // set caughtFish false so this won't go off twice
                caughtFish = false;
                // call the function in fishcollections
                fishCollection.RandomFish();
                // set the text false else you see it 
                testText1.gameObject.SetActive(false);
                // enable the right cam
                fishCam.enabled = false;
                mainCam.enabled = true;
            }
            // if you failed to catch the fish (so if failedFish = true
            if (failedFish)
            {
                // enable the right cam
                fishCam.enabled = false;
                mainCam.enabled = true;
                // reset the ring and cube by setting revert to true
                revert = true;
                // setting failedFish to false so you can fail it again ;)
                failedFish = false;
            }
        }
    }
}
