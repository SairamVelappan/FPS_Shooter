using UnityEngine;

namespace FPS.Weapons
{
    public class WeaponSway : MonoBehaviour
    {
        [SerializeField] private float _swayIntensity;
        [SerializeField] private float _swayMultiper;

        private float _mouseX, _mouseY;
        Quaternion _rotationX, _rotationY, _targetRotation;

        private void Update()
        {
            _mouseX = Input.GetAxisRaw("Mouse X") * _swayMultiper;
            _mouseY = Input.GetAxisRaw("Mouse Y") * _swayMultiper;

            _rotationX = Quaternion.AngleAxis(-_mouseY, Vector3.right);
            _rotationY = Quaternion.AngleAxis(_mouseX, Vector3.up);

            _targetRotation = _rotationY * _rotationX;

            transform.localRotation = Quaternion.Slerp(transform.localRotation, _targetRotation, _swayIntensity * Time.deltaTime);
        }
    }
}
