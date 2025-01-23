using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class SaveCaughtFish : MonoBehaviour
    {
        // references to other scripts
        [SerializeField] Fish_o_pedia fishOpedia;

        [SerializeField] string Fish1;
        [SerializeField] string Fish2;
        [SerializeField] string Fish3;

        private void Start()
        {
            LoadFishData();
        }

        // save the data
        public void SaveFishData()
        {
            // if you caught the specific fish then save it to a specific string
            if (fishOpedia.randomFish == "fish1")
            {
                Fish1 = fishOpedia.randomFish;
                PlayerPrefs.SetString("Fish1", Fish1);
            }
            if (fishOpedia.randomFish == "fish2")
            {
                Fish2 = fishOpedia.randomFish;
                PlayerPrefs.SetString("Fish2", Fish2);
            }
            if (fishOpedia.randomFish == "fish3")
            {
                Fish3 = fishOpedia.randomFish;
                PlayerPrefs.SetString("Fish3", Fish3);
            }
        }

        // load the data 
        private void LoadFishData()
        {
            // if there is a value saved then load it 
            Fish1 = PlayerPrefs.GetString("Fish1");
            Fish2 = PlayerPrefs.GetString("Fish2");
            Fish3 = PlayerPrefs.GetString("Fish3");
        }
    }
}