using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody rb;
        public InputManagerPlayerAction inputManager;
        public float speed;
        public float runSpeed;
        float jumpForce;

        private void Start() {
            rb = GetComponent<Rigidbody>();
            inputManager.playerInput.Movement.Jump.performed += ctx => Jump();

            
            // if(controller.inputManager.playerControl.Movement.Jump.WasPressedThisFrame())
            //     controller.SwitchStates(new JumpState(controller));
        }
        

        private void Jump()
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
