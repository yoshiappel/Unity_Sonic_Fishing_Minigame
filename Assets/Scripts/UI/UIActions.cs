using UnityEngine;

namespace Sonic.UI
{
    public class UIActions : MonoBehaviour
    {
        [SerializeField] private KeyCode prevKey = KeyCode.Q;
        [SerializeField] private KeyCode nextKey = KeyCode.E;

        [SerializeField] private GameObject[] uiScreens;

        private int currentIndex = 0;

        private void Start()
        {
            UpdateUI();
        }

        private void Update()
        {
            if (Input.GetKeyUp(prevKey))
            {
                MoveToPrevious();
            }
            else if (Input.GetKeyUp(nextKey))
            {
                MoveToNext();
            }
        }

        private void MoveToPrevious()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateUI();
            }
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