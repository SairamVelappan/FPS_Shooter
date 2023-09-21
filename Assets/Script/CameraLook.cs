using System;
using UnityEngine;

namespace FPS
{
    public class CameraLook : MonoBehaviour
    {
        public InputManagerPlayerAction inputManager;

        public float mouseLookSens = 25;
        public Transform body;

        private Vector3 _recoilDirection;

        public static Action<Vector3> getRecoilDirection;

        private float xRot = 0;

        private void OnEnable() 
        {
            getRecoilDirection += GetRecoilDirection;
        }
        private void OnDisable() 
        {
            getRecoilDirection -= GetRecoilDirection;
        }

        private void Start() 
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void LateUpdate()
        {
            float mouseX = inputManager.playerInput.CameraLook.MouseX.ReadValue<float>() * mouseLookSens * Time.deltaTime;
            float mouseY = inputManager.playerInput.CameraLook.MouseY.ReadValue<float>() * mouseLookSens * Time.deltaTime;

            xRot -= mouseY;
            xRot = Mathf.Clamp(xRot, -90f, 90f);
            
            transform.localRotation = Quaternion.Euler(xRot + _recoilDirection.x, _recoilDirection.y, _recoilDirection.z);
            body.Rotate(Vector3.up * mouseX);
        }

        private void GetRecoilDirection(Vector3 direction)
        {
            _recoilDirection = direction;
        }

    }
}
