using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YA
{
    public class UISystem : MonoBehaviour
    {
        // references to other scripts
        [SerializeField] InputScript inputScript;

        // menu UI Buttons
        [Header("Buttons")]
        [SerializeField] Button goFishing;
        [SerializeField] Button fishopedia;
        [SerializeField] Button quitGame;

        // MenuUI Canvas
        [Header("Canvases")]
        [SerializeField] Canvas menuUI;

        // ChooseFishLocationUI Canvas
        [SerializeField] Canvas chooseFishLocationUI;

        // MinigameUI Canvas
        [SerializeField] Canvas minigameUI;

        // fishopediaUI Canvas
        [SerializeField] Canvas fishopediaUI;

        // caughtfishUI canvas
        [SerializeField] Canvas caughtFishUI;

        // caughtfishUI canvas
        [SerializeField] Canvas failedFishUI;

        // Holders (Obj) MinigameUi
        [Header("Holders")]
        [SerializeField] GameObject quitObj;
        [SerializeField] GameObject reel_It_InObj;
        [SerializeField] GameObject hook_The_FishObj;

        // main menu buttons functions
        public void OnGoFishing()
        {
            if (inputScript.canFish)
            {
                inputScript.StartFishing();
                menuUI.gameObject.SetActive(false);
                chooseFishLocationUI.gameObject.SetActive(true);
            }
        }

        public void OnFishopedia()
        {
            menuUI.gameObject.SetActive(false);
            fishopediaUI.gameObject.SetActive(true);
        }

        // this calls if f is pressed (other script)
        public void OnCastTheLine()
        {
            chooseFishLocationUI.gameObject.SetActive(false);
            minigameUI.gameObject.SetActive(true);
        }

        public void OnReelIn()
        {
            hook_The_FishObj.SetActive(true);
        }

        public void OnHookTheFish()
        {
            hook_The_FishObj.SetActive(false);
            reel_It_InObj.SetActive(true);
            minigameUI.gameObject.SetActive(false);
            if (inputScript.caughtFish)
            {
                caughtFishUI.gameObject.SetActive(true);
            }
            if (inputScript.failedFish)
            {
                failedFishUI.gameObject.SetActive(true);
            }
        }

        // for when i have animations
        //public void OnQuitFishing()
        //{
            //minigameUI.gameObject.SetActive(false);
            //menuUI.gameObject.SetActive(true);
        //}

        public void OnQuitGame()
        {
            Application.Quit();
            Debug.Log("Quit_Game");
        }
    }
}
