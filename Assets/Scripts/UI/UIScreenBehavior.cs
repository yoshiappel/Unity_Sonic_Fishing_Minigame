using UnityEngine;

namespace Sonic.UI
{
    public class UIScreenBehavior : MonoBehaviour
    {
        public UIActions actions;
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
