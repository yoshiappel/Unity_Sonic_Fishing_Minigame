using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class Fish_o_pedia : MonoBehaviour
    {
        // references to other scripts
        [SerializeField] InputScript inputScript;
        [SerializeField] SaveCaughtFish saveCaughtFish;

        // gameObjects
        public GameObject fishCaught;

        // The list for all the fishes
        List<string> fishBestiary;

        // Strings
        public string randomFish;

        // On start
        public void Start()
        {
            // create the fishes
            fishBestiary = new List<string> { "fish1", "fish2", "fish3" };
        }

        // a function to pick a random fish
        string PickRandomFish(List<string> fishList)
        {
            // make sure the random range can't go lower than 0 or higher than the list.count
            int randomIndex = Random.Range(0, fishList.Count);
            // return the string with a random index so it can take that item out of the list fishBestiary
            return fishList[randomIndex];
        }

        public void RandomFish()
        {
            // put a random item from the list in randomFish trough PickRandomFish function
            randomFish = PickRandomFish(fishBestiary);
            // set this gameObject true (its a holder for a text)
            fishCaught.gameObject.SetActive(true);
            // display the caught fish
            inputScript.testText2.text = "You caught a: " + randomFish;
            saveCaughtFish.SaveFishData();
        }

    }
}