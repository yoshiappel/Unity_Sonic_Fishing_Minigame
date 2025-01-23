using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YA
{
    public class UISystem : MonoBehaviour
    {
        // ui things
        [SerializeField] Button GoFishing;
        [SerializeField] Button Fishopedia;
        [SerializeField] Button QuitGame;

        public void OnQuitGame()
        {
            Application.Quit();
            Debug.Log("Quit_Game");
        }
    }
}
