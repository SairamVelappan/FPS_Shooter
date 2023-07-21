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

        void Update()
        {

            _targetRotation = Vector3.Lerp(_targetRotation, Vector3.zero, _returnSpeed * Time.deltaTime);
            _currentRotation = Vector3.Slerp(_currentRotation, _targetRotation, _snappiness * Time.deltaTime);
            transform.localRotation = Quaternion.Euler(_currentRotation);

        }

        void Recoil(float recoilDirection)
        {
            _targetRotation += new Vector3(-recoilDirection,
                UnityEngine.Random.Range(-recoilDirection/2, recoilDirection/2),
                0);
        }



    }
}
