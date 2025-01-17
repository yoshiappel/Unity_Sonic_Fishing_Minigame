using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace YA
{
    public class QuickTimeEvent : MonoBehaviour
    {
        // references to other scripts
        [SerializeField] InputScript inputScript;
        [SerializeField] RandomRings randomRings;
        [SerializeField] CubeQTE cubeQTE;

        // bools
        public bool Loop;

        //gameObjects
        public GameObject ringQT;

        // this calls every frame
        private void Update()
        {
            // check if it should revert the scale
            RevertScale();
        }

        // on the start of the game
        private void Start()
        {
            // make sure it the right scale when the game starts
            ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        }

        // the QTE for the ring 
        public async void FishQuickTimeEvent1()
        {
            // set the Loop true so the while loop works
            Loop = true;
            // a while Loop that only stops when you catch a fish or fail to catch the fish
            while (Loop)
            {
                // delay
                await Task.Delay(1);
                // change the scale 
                ringQT.transform.localScale += new Vector3(0.001f, 0, 0.001f);
            }

        }

        // revert the scale if needed
        private void RevertScale()
        {
            // if the circle has become to big or the revert bool is true
            if (ringQT.transform.localScale.x >= 1 || inputScript.revert)
            {
                // reset the localscale of rinQT
                ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
                // reset the localposition of cubeQTE
                cubeQTE.cubeQTE_OBJ.transform.localPosition = new Vector3(0, 0, 1.24f);
                // set the bool false so it won't call twice
                inputScript.revert = false;
            }
        }

        // if you quit out of the Application reset the ringQT localScale and set loop to false
        private void OnApplicationQuit()
        {
            ringQT.transform.localScale = new Vector3(0.1f, 1, 0.1f);
            Loop = false;
        }
    }
}
