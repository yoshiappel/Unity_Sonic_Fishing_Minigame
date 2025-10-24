using UnityEngine;
using TMPro;

namespace Sonic.UI
{
    public class Screen02 : UIScreenBehavior
    {
        public override void OnScreenActivated()
        {
            base.OnScreenActivated();
            messageText.text = "Quit";
            keyText.text = "Q";
            actions.canQuit = true;
            actions.canIncrement = false;
        }
    }
}