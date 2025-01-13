using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class FishCollection : MonoBehaviour
    {

        public InputScript inputScript;

        [SerializeField] GameObject fishCaught;

        List<string> fishBestiary;
        public string randomFish;


        public void Start()
        {
            fishBestiary = new List<string> { "fish1", "fish2", "fish3" };
            randomFish = PickRandomFish(fishBestiary);

        }

        string PickRandomFish(List<string> fishList)
        {
            int randomIndex = Random.Range(0, fishList.Count);
            return fishList[randomIndex];
        }

        public void RandomFish()
        {
            fishCaught.gameObject.SetActive(true);
            inputScript.testText2.text = "You caught a: " + randomFish;
        }

    }
}