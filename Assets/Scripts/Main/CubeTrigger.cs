using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class CubeTrigger : MonoBehaviour
    {
        // references
        public InputScript inputScript;
        public QuickTimeEvent QTE;

        // collision gameObject
        [SerializeField] GameObject cube;

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Cube")
            {
                if (Input.GetKey(inputScript.ReelIn))
                {
                    QTE.Loop = false;
                    Debug.Log("Start");
                    inputScript.caughtFish = true;
                    QTE.ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
                }
            }
        }

    }
}