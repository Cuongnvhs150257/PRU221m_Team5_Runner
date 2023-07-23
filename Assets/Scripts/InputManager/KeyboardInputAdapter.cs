using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class KeyboardInputAdapter : IInputAdapter
    {
        public float GetJumpInput()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                return 1f;
            }
            else
            return 0f;
        }
    }

}
