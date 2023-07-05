using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class CameraLook : MonoBehaviour
    {
        public InputManager inputManager;

        public float mouseLookSens = 25;
        public Transform body;

        private float xRot = 0;

        private void Start() {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void LateUpdate() {
            float mouseX = inputManager.playerControl.CameraLook.MouseX.ReadValue<float>() * mouseLookSens * Time.deltaTime;
            float mouseY = inputManager.playerControl.CameraLook.MouseY.ReadValue<float>() * mouseLookSens * Time.deltaTime;

            xRot -= mouseY;
            xRot = Mathf.Clamp(xRot, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRot, 0f,0f);
            body.Rotate(Vector3.up * mouseX);
        }
    }
}
