using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace YA
{
    public class QuickTimeEvent : MonoBehaviour
    {
        [SerializeField] GameObject ringQT;

        public InputScript inputScript;


        public async void FishQuickTimeEvent()
        {
            for (int i = 0; i < 9; i++)
            {
                await Task.Delay(1000);
                ringQT.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);

                if ((Input.GetKey(KeyCode.B) && ringQT.transform.localScale.y > 0.3f && ringQT.transform.localScale.y < 0.5f))
                {
                    Debug.Log("heheheh");
                }

            }
        }
    }
}
