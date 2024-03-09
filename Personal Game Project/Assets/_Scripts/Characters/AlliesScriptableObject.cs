using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Ally Scriptable Objects")]
public class AlliesScriptableObject : CharacterScriptableObject
{
    [SerializeField] private Player player;

    [Serializable]
    public struct Player
    {
        public string name;
        public int Stars;
        public int level;
        public int currentExp;
        public int maxExp;
    }

    public enum Attacks
    {
        Basic,
        SkillOne,
        SkillTwo,
        SkillThree,
        Ult,
    }

    public Attacks[] AttackPatterns = new Attacks[12];
    
}
