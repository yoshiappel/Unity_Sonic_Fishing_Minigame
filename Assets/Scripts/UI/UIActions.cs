using UnityEngine;

namespace Sonic.UI
{
    public class UIActions : MonoBehaviour
    {
        [SerializeField] private KeyCode quitKey = KeyCode.Q;
        [SerializeField] private KeyCode nextKey = KeyCode.E;

        [SerializeField] private GameObject[] uiScreens;
        [SerializeField] private GameObject[] mgUIScreens;

        [SerializeField] private GameObject mgScreen;

        [SerializeField] private int currentUIScreenIndex = 0;
        [SerializeField] private int currentMGUIScreenIndex = 0;

        public bool isMG;

        public bool canQuit;
        public bool canIncrement;

        private void Start()
        {
            UpdateUI();
        }

        private void Update()
        {
            if (Input.GetKeyUp(quitKey) && canQuit && isMG)
            {
                QuitMG();
            }
            else if (Input.GetKeyUp(nextKey) && canIncrement && isMG)
            {
                MoveToNext();
            }
        }

        private void QuitMG()
        {
            if (currentMGUIScreenIndex == 0)
            {
                currentUIScreenIndex = 0;
                isMG = false;
            }
            else if (currentMGUIScreenIndex == 1)
            {
                currentMGUIScreenIndex = 0;
            }
            UpdateUI();
        }

        private void MoveToNext()
        {
            if (currentMGUIScreenIndex < mgUIScreens.Length - 1)
            {
                currentMGUIScreenIndex++;
                UpdateUI();
            }
        }
        private void UpdateUI()
        {
            for (int i = 0; i < mgUIScreens.Length; i++)
            {
                bool isActive = (i == currentMGUIScreenIndex);
                mgUIScreens[i].SetActive(isActive);

                var behavior = mgUIScreens[i].GetComponent<UIScreenBehavior>();
                if (behavior != null)
                {
                    if (isActive)
                        behavior.OnScreenActivated();
                    else
                        behavior.OnScreenDeactivated();
                }
            }
            for (int i = 0; i < uiScreens.Length; i++)
            {
                bool isActive = (i == currentUIScreenIndex);
                uiScreens[i].SetActive(isActive);

                var behavior = uiScreens[i].GetComponent<UIScreenBehavior>();
                if (behavior != null)
                {
                    if (isActive)
                        behavior.OnScreenActivated();
                    else
                        behavior.OnScreenDeactivated();
                }
            }
        }

        public void StartMG()
        {
            canQuit = true;
            isMG = true;
            currentUIScreenIndex = 2;
            UpdateUI();
        }

        public void FishOPedia()
        {
            currentUIScreenIndex = 1;
            UpdateUI();
        }
    }
}