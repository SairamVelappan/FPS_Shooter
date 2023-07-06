using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Character.Abilities.ClassAbilities;

namespace FPS
{
    public class TitanClassAbility : ClassAbility
    {
        public override void Perform()
        {
           Instantiate(classAbilityPrefab,transform.position+offset,Quaternion.identity);
        }
    }
}
