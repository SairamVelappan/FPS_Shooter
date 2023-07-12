using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS.Character.Abilities.ClassAbilities
{
    
    public abstract class ClassAbility : MonoBehaviour
    {
        public GameObject classAbilityPrefab;
        public Vector3 offset;

        public abstract void Perform(TempCharACTER charACTER);
    }
}