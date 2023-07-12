using System;
using System.Collections.Generic;
using UnityEngine;

namespace FPS.Controller
{
    public class PlayerWeaponController : MonoBehaviour
    {
        public static Action playerShoot;

        private void Update() 
        {
            if(Input.GetMouseButton(0))
            {
                playerShoot?.Invoke();
            }
        }
    }
}
