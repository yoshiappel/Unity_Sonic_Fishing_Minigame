using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class SaveCaughtFish : MonoBehaviour
    {
        // references to other scripts
        [SerializeField] Fish_o_pedia fishOpedia;

        [SerializeField] string Carp;
        [SerializeField] string Medaka;
        [SerializeField] string Marlin;

        private void Start()
        {
            LoadFishData();
        }

        // save the data
        public void SaveFishData()
        {
            // if you caught the specific fish then save it to a specific string
            if (fishOpedia.randomFish == "Carp")
            {
                Carp = fishOpedia.randomFish;
                PlayerPrefs.SetString("Carp", Carp);
            }
            if (fishOpedia.randomFish == "Medaka")
            {
                Medaka = fishOpedia.randomFish;
                PlayerPrefs.SetString("Medaka", Medaka);
            }
            if (fishOpedia.randomFish == "Marlin")
            {
                Marlin = fishOpedia.randomFish;
                PlayerPrefs.SetString("Marlin", Marlin);
            }
        }

        // load the data 
        private void LoadFishData()
        {
            // if there is a value saved then load it 
            Carp = PlayerPrefs.GetString("Fish1");
            Medaka = PlayerPrefs.GetString("Fish2");
            Marlin = PlayerPrefs.GetString("Fish3");
        }
    }
}