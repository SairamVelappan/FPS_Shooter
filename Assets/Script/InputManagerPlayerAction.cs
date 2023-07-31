using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class InputManagerPlayerAction : MonoBehaviour
    {
        public PlayerInput playerInput;

        private void Awake() => playerInput = new PlayerInput();

        private void OnEnable() 
        {
            playerInput.Enable();    
        }
        
        private void OnDisable() 
        {
            playerInput.Disable();
        }
            
        
    }
}
