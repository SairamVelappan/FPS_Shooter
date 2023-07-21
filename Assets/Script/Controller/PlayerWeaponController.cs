using System;
using UnityEngine;

namespace FPS.Controller
{
    public class PlayerWeaponController : MonoBehaviour
    {
        public static Action playerShoot;
        public static Action playerReload;

        private void Update() 
        {
            if(Input.GetMouseButton(0))
            {
                playerShoot?.Invoke();
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                playerReload?.Invoke();
            }
        }
    }
}
