using System;
using UnityEngine;

namespace FPS.Controller
{
    public class PlayerWeaponController : MonoBehaviour
    {
        [SerializeField]private InputManagerPlayerAction _inputManager;
        public static Action playerShoot;
        public static Action playerReload;

        private void Start() 
        {
            _inputManager.playerInput.Movement.Reload.performed += ctx => playerReload?.Invoke();
        }

        private void OnDisable() 
        {
            _inputManager.playerInput.Movement.Reload.performed -= ctx => playerReload?.Invoke();
        }

        private void Update() 
        {
           if(_inputManager.playerInput.Movement.Fire.IsPressed())
           {
                playerShoot?.Invoke();
           }
        }
    }
}
