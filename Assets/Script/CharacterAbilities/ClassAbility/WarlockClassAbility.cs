using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Character.Abilities.ClassAbilities;

namespace FPS.Character.Abilities.ClassAbilities
{
    public class WarlockClassAbility : ClassAbility
    {
        public override void Perform(TempCharACTER aCTER)
        {
           Instantiate(classAbilityPrefab,aCTER.transform.position+offset,Quaternion.identity);
        }
    }
}
