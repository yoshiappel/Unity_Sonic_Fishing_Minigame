using TMPro;
using UnityEngine;

namespace Sonic.UI
{
    public class UIScreenBehavior : MonoBehaviour
    {
        public UIActions actions;
        public TMP_Text messageText;
        public TMP_Text keyText;
        public virtual void OnScreenActivated()
        {
            Debug.Log($"{gameObject.name} activated");
        }

        public virtual void OnScreenDeactivated()
        {
            Debug.Log($"{gameObject.name} deactivated");
        }
    }
}
