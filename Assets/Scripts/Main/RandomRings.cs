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

        public void RandomSpawnRing()
        {
            Vector3 randomScale = new Vector3(Random.Range(0.3f, 0.9f), 1, Random.Range(0.3f, 0.9f));
            randomScale.z = randomScale.x;
            targetRing.transform.localScale = randomScale;
        }
    }
}
