using System.Collections;
using FPS.Controller;
using UnityEngine;

namespace FPS.Weapons
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField]private WeaponData _weaponData;

        private int _currentAmmoCount;
        private bool _isReloading;
        private float _timeBetweenEachShot;

        private void OnEnable() 
        {
            PlayerWeaponController.playerShoot += Shoot;
        }
        private void OnDisable() 
        {
            PlayerWeaponController.playerShoot -= Shoot;
        }

        private void Start() 
        {
            _currentAmmoCount = _weaponData.magSize;
        }

        private void Update() 
        {
            _timeBetweenEachShot += Time.deltaTime;
        }

        private bool CanShoot()
        {
            return (_currentAmmoCount > 0 && !_isReloading && _timeBetweenEachShot > 1f/(_weaponData.roundsPerMinute/60f));
        }

        private void Shoot()
        {
            Debug.Log("Entering shoot");
            if(CanShoot())
            {
                Debug.Log("Actual entery");
                if(Physics.Raycast(transform.position,transform.forward,out RaycastHit hitInfo,_weaponData.range))
                {
                    Debug.Log(hitInfo.transform.name + " Is hit");
                }

                _currentAmmoCount--;
                _timeBetweenEachShot = 0;
            }
        }
    }
}
