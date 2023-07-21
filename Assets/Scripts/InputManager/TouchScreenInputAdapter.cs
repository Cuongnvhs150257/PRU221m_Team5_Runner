using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class TouchScreenInputAdapter : IInputAdapter
    {
        public float GetJumpInput()
        {
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                return 1f;
            }
            return 0f;
        }
    }
}
