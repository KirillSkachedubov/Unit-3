using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X key down");
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("z key down");
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space  key down");
            }
        }
    }
}
