using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.AnimatedValues;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using JetBrains.Annotations;
using System;
using UnityEngine.UIElements;

public class InputScript : MonoBehaviour
{

    
    [SerializeField] Rigidbody ballRigidbody;
    [SerializeField] Camera cam;
    [SerializeField] GameObject ring;
    public bool canfish = false;

    [SerializeField] TMP_Text Text1;

    public GameObject ball;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Text1.enabled = false;
            cam.enabled = true;
            canfish = true;


        }

        if (Input.GetKeyDown(KeyCode.G) && canfish)
        {
            ring.SetActive(false);
            canfish = false;
        }
    }

}
