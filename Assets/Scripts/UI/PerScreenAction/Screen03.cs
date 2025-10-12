using UnityEngine;
using TMPro;

namespace Sonic.UI
{
    public class Screen03 : UIScreenBehavior
    {
        [SerializeField] private TMP_Text messageText;

        public override void OnScreenActivated()
        {
            base.OnScreenActivated();
            messageText.text = "Reel it in";
        }
    }
}