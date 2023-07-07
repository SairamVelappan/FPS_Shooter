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
            inputManager.playerControl.Movement.Jump.started +=_=> Jump();
        }

        private void Update() {
            // float forward = inputManager.playerControl.Movement.Forward.ReadValue<float>(); 
            // float right = inputManager.playerControl.Movement.Right.ReadValue<float>(); 

            // movement = inputManager.playerControl.Movement.WASD.ReadValue<Vector2>();

            // Vector3 move = transform.right * movement.x + transform.forward * forward;

            // move *= inputManager.playerControl.Movement.Run.ReadValue<float>() == 0 ? speed : runSpeed;
            // rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
        }

        private void Jump()
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
