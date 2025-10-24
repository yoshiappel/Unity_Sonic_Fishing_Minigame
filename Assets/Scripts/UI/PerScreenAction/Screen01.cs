using UnityEngine;
using TMPro;

namespace Sonic.UI
{
    public class Screen01 : UIScreenBehavior
    {
        public override void OnScreenActivated()
        {
            base.OnScreenActivated();
            messageText.text = "Cast The Line";
            keyText.text = "E";
            actions.canIncrement = true;
        }
    }
}