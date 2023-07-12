using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS.SO
{
    [CreateAssetMenu(fileName ="CharacterStats", menuName = "ScriptableObjects/CharacterStats", order = 1)]
    public class CharacterStats : ScriptableObject
    {
        public float jumpForce = 5f;
        public float speed;
        public float runSpeed;
        public bool isGrounded;
    }
}
