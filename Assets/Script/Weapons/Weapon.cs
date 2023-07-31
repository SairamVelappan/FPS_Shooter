using System.Collections;
using FPS.Controller;
using UnityEngine;

namespace FPS.Weapons
{
    public class Weapon : MonoBehaviour
    {
        #region Variables
        [Header("Main Weapon Properties")]
        [Tooltip("Used to hold the weapons data")]
        [SerializeField]private WeaponData _weaponData;  // refernece to the weapon data

        [SerializeField]private Transform _muzzleTransform;

        private int _currentAmmoCount; // current ammo present in the mag
        private bool _isReloading; // bool to check if we are reloading or not
        private float _timeBetweenEachShot; // a temp var to store time 


        [Header("Secondary Properties")]

        [Tooltip("Camera transform used to get position from which the raycast is shot")]
        [SerializeField]private Transform _cameraTransform;

        #endregion

        #region UnityCallbacks

        private void OnEnable() 
        {
            PlayerWeaponController.playerShoot += Shoot;
            PlayerWeaponController.playerReload += Reload;
        }
        private void OnDisable() 
        {
            PlayerWeaponController.playerShoot -= Shoot;
            PlayerWeaponController.playerReload -= Reload;
        }

        private void Start() 
        {
            _currentAmmoCount = _weaponData.magSize;
        }

        private void Update() 
        {
            _timeBetweenEachShot += Time.deltaTime;
        }

        #endregion

        #region Private Methods

        // bool to check if we can shoot or not
        private bool CanShoot()
        {
            return (_currentAmmoCount > 0 && !_isReloading && _timeBetweenEachShot > 1f/(_weaponData.roundsPerMinute/60f));
        }

        // actual shoot function
        private void Shoot()
        {
            Debug.Log("Entering shoot");
            if(CanShoot())
            {
                Debug.Log("Actual entery");
                TrailRenderer trail = Instantiate(_weaponData.bulletTrail,_muzzleTransform.position,Quaternion.identity);

                if(Physics.Raycast(_cameraTransform.position,transform.forward,out RaycastHit hitInfo,_weaponData.range))
                {
                    Debug.Log(hitInfo.transform.name + " Is hit");
                    StartCoroutine(SpawnTrail(trail,hitInfo.point));
                }
                else
                {
                    StartCoroutine(SpawnTrail(trail,transform.forward * _weaponData.range));
                }

                WeaponRecoil.initializeRecoil(_weaponData.recoilDirection);

                _currentAmmoCount--;
                _timeBetweenEachShot = 0;
            }
        }

        // actual reload function
        private void Reload()
        {
            if(!_isReloading && _currentAmmoCount != _weaponData.magSize)
            {
                StartCoroutine(ReloadingProcess());
            }
            
        }
        #endregion

        #region Coroutines

        // coroutine used to wait for some seconds before filling mag
        IEnumerator ReloadingProcess()
        {
            _isReloading = true;
            Debug.Log("reloading");
            yield return new WaitForSeconds((100/_weaponData.reloadSpeed) - 0.5f);
            _currentAmmoCount = _weaponData.magSize;
            _isReloading = false;
            Debug.Log("reloaded");
        }

        IEnumerator SpawnTrail(TrailRenderer trail,Vector3 endPos)
        {
            float time = 0;
            Vector3 startPos= trail.transform.position;

            while(time < 1)
            {
                trail.transform.position = Vector3.Lerp(startPos,endPos,time);
                time += Time.deltaTime / trail.time;

                yield return null;
            }

            Destroy(trail.gameObject,trail.time);
        }

        #endregion
    }
}
