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
        public bool caughtFish = false;

        // text variables
        [Header("Text")]
        [SerializeField] TMP_Text testText1;
        public TMP_Text testText2;

        // reference the other scripts
        public FishCollection fishCollection;
        public QuickTimeEvent quickTimeEvent;



        private void Update()
        {
            // calls this function every frame
            CheckInput();
        }

        private void CheckInput()
        {
            // if F and canCast == true
            if (Input.GetKeyDown(KeyCode.F) && canFish)
            {
                testText1.enabled = false;
                fishCam.enabled = true;
                mainCam.enabled = false;
                // make sure you CAN cast the rod 
                canCast = true;
                // make sure you can't choose to fish twice 
                canFish = false;
            }
            // cast the rod
            // if G and canFish == true
            if (Input.GetKeyDown(KeyCode.G) && canCast)
            {
                // this is for testing
                ring.gameObject.SetActive(false);
                // make sure you cant cast twice
                canCast = false;
                // start the qte
                quickTimeEvent.FishQuickTimeEvent1();
            }
            // if this is true (its only true if you complete the qte)
            if (caughtFish)
            {
                caughtFish = false;
                // call the function in fishcollections
                fishCollection.RandomFish();
                // set the text false else you see it 
                testText1.gameObject.SetActive(false);
                // enable the right cam
                fishCam.enabled = false;
                mainCam.enabled = true;
            }
        }
    }
}
