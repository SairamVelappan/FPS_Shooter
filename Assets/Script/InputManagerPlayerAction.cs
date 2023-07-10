using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class InputManagerPlayerAction : MonoBehaviour
    {
        public PlayerControlles playerControl;

        private void Awake() => playerControl = new PlayerControlles();

        private void OnEnable() 
        {
            playerControl.Enable();    
        }
        
        private void OnDisable() {
            playerControl.Disable();
        }
            
        
    }
}
