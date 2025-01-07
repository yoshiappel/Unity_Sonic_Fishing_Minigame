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
        [SerializeField] Camera cam;
        [SerializeField] GameObject ring;

        // bools
        [Header("Bools")]
        public bool canFish = true;
        public bool canCast = false;

        // text variables
        [SerializeField] TMP_Text testText1;
        public TMP_Text testText2;


        public FishCollection fishCollection;


        public GameObject ball;
        private void Update()
        {
            CheckInput();
        }

        private void CheckInput()
        {
            // if F and canCast == true
            if (Input.GetKeyDown(KeyCode.F) && canFish)
            {
                testText1.enabled = false;
                cam.enabled = true;
                // make sure you CAN cast the rod 
                canCast = true;
                // make sure you can't choose to fish twice 
                canFish = false;
            }
            // cast the rod
            // if G and canFish == true
            if (Input.GetKeyDown(KeyCode.G) && canCast)
            {
                ring.SetActive(false);
                canCast = false;

                fishCollection.RandomFish();
            }
        }
    }
}
