using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Character.Abilities.ClassAbilities;

namespace FPS.Character.Abilities.ClassAbilities
{
    public class HunterClassAbility : ClassAbility
    {
        [SerializeField]private float _dogdeDistance;

        public override void Perform(TempCharACTER aCTER)
        {
            offset = transform.forward * _dogdeDistance;
            aCTER.transform.position = Vector3.Lerp(aCTER.transform.position,aCTER.transform.position + offset,2);
        }
    }
}
