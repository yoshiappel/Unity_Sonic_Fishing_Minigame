using UnityEngine;
using TMPro;
using Sonic.Minigame;

namespace Sonic.UI
{
    public class Screen01 : UIScreenBehavior
    {
        [SerializeField] CastLine castLine;
        [SerializeField] GameObject cam0;
        [SerializeField] GameObject cam1;

        public override void OnScreenActivated()
        {
            base.OnScreenActivated();
            messageText.text = "Cast The Line";
            keyText.text = "E";
            actions.canIncrement = true;
            castLine.canCast = true;
            cam0.SetActive(false);
            cam1.SetActive(true);
        }

        private void Update()
        {
            if (Input.GetKey(actions.nextKey))
            {
                castLine.canCast = false;
            }
        }
    }
}