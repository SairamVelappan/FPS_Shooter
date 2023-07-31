using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS.Weapons
{
    [CreateAssetMenu(fileName = "New Weapon Data",menuName ="Weapons/WeaponData",order = 51)]
    public class WeaponData : ScriptableObject
    {
        [Header("Info")]
       public new string name;

       [Header("Main Stats")]
       public float impact;
       public float range;
       public float stability;
       public float handling;
       public float reloadSpeed;
       public float zoom;
       public float roundsPerMinute;
       public int magSize;

       public float recoilDirection;


       public TrailRenderer bulletTrail;

    
    }
}
