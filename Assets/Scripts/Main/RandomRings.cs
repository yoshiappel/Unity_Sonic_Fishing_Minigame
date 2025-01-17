using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class RandomRings : MonoBehaviour
    {
        // references
        [SerializeField] QuickTimeEvent QTE;
        [SerializeField] InputScript inputScript;

        // gameObjects
        public GameObject targetRing;

        // vector3's for calculating the location of the targetRing (only for testing)
        public Vector3 point1;
        public Vector3 point2;

        // for making the targetRing's localscale bigger/smaller at random // not used at the moment
        public void RandomSpawnRing()
        {
            Vector3 randomScale = new Vector3(Random.Range(0.300f, 0.800f), 1, 1);
            randomScale.z = randomScale.x;
            targetRing.transform.localScale = randomScale;
        }

        // only usefull for the old ring system 
        // calculate the location of the targetRing so you can easily test it 
        public void CalculateTargetRing()
        {
            // make the window where you can press the reel button bigger (so it is easier)
            point1 = new Vector3(targetRing.transform.localScale.x - 0.1f, 0, 0);
            point2 = new Vector3(targetRing.transform.localScale.x + 0.1f, 0, 0);
            // log the points for testing
            Debug.Log(point1);
            Debug.Log(point2);
        }
    }
}
