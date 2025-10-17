using UnityEngine;

namespace Sonic.UI
{
    public class UIActions : MonoBehaviour
    {
        [SerializeField] private KeyCode quitKey = KeyCode.Q;
        [SerializeField] private KeyCode nextKey = KeyCode.E;

        [SerializeField] private GameObject[] uiScreens;

        private int currentIndex = 0;

        [SerializeField] private bool canQuit;
        public bool canIncrement;

        private void Start()
        {
            UpdateUI();
        }

        private void Update()
        {
            if (Input.GetKeyUp(quitKey) && canQuit)
            {
                QuitMG();
            }
            else if (Input.GetKeyUp(nextKey) && canIncrement)
            {
                MoveToNext();
            }
        }

        private void QuitMG()
        {
            currentIndex = 0;
            UpdateUI();
        }

        private void MoveToNext()
        {
            if (currentIndex < uiScreens.Length - 1)
            {
                currentIndex++;
                UpdateUI();
            }
        }
        private void UpdateUI()
        {
            for (int i = 0; i < uiScreens.Length; i++)
            {
                bool isActive = (i == currentIndex);
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
    }
}