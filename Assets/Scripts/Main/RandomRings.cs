using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class RandomRings : MonoBehaviour
    {
        // references
        public QuickTimeEvent QTE;
        public InputScript inputScript;

        public GameObject targetRing;

        public Vector3 point1;
        public Vector3 point2;

        // for calculating the old ring system // not used at the moment
        public void RandomSpawnRing()
        {
            Vector3 randomScale = new Vector3(Random.Range(0.300f, 0.800f), 1, 1);
            randomScale.z = randomScale.x;
            targetRing.transform.localScale = randomScale;
        }

        public void CalculateTargetRing()
        {
            point1 = new Vector3(targetRing.transform.localScale.x - 0.1f, 0, 0);
            point2 = new Vector3(targetRing.transform.localScale.x + 0.1f, 0, 0);
            Debug.Log(point1);
            Debug.Log(point2);
        }
    }
}
