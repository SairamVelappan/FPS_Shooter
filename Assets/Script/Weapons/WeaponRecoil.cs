using System;
using UnityEngine;

namespace FPS.Weapons
{
    public class WeaponRecoil : MonoBehaviour
    {
        private Vector3 _currentRotation,_targetRotation;

        [SerializeField]private float _snappiness,_returnSpeed;

        public static Action<float> initializeRecoil;

        private void Start()
        {
            initializeRecoil += Recoil;
        }

        private void OnDisable() 
        {
            initializeRecoil -= Recoil;
        }
        private void Update() 
        {
            _targetRotation = Vector3.Lerp(_targetRotation, Vector3.zero, _returnSpeed * Time.deltaTime);
            _currentRotation = Vector3.Slerp(_currentRotation, _targetRotation, _snappiness * Time.deltaTime);
            CameraLook.getRecoilDirection.Invoke(_currentRotation);
        }

        void Recoil(float recoilValue)
        {
            _targetRotation += new Vector3(-recoilValue,
                UnityEngine.Random.Range(-recoilValue / 2, recoilValue / 2),
                0);
        }

    }
}
