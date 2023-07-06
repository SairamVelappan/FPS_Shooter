using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Character.Abilities.ClassAbilities;

namespace FPS.Character
{
    public class TempCharACTER : MonoBehaviour
    {
       [SerializeField] private CharacterClass _characterClass;

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.V))
            {
                _characterClass.classAbility.Perform();
            }
        }
    }
}
