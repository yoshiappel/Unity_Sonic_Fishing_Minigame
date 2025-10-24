using UnityEngine;
using TMPro;

namespace Sonic.UI
{
    public class Screen03 : UIScreenBehavior
    {
        public override void OnScreenActivated()
        {
            base.OnScreenActivated();
            messageText.text = "Reel it in";
        }
    }
}