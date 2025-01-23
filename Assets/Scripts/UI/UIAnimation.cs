using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YA
{
    public class UIAnimation : MonoBehaviour
    {
        [SerializeField] RectTransform rectTransform;

        [SerializeField] Vector2 desiredScale = new Vector2(1.06f, 1.06f);
        [SerializeField] Vector2 startScale = new Vector2(1, 1);
        public void ScaleButton()
        {
            rectTransform.localScale = desiredScale;
        }

        public void UnScaleButton()
        {
            rectTransform.localScale = startScale;
        }
    }
}
