using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public abstract class CharacterScriptableObject : ScriptableObject
{
    public Faction faction;
    [SerializeField] private Stats _stats;
    public Stats BaseStats => _stats;
    [SerializeField]
    public GameObject prefeb;

    [Serializable]
    public struct Stats
    {
        public int health;
        public int phyAtk;
        public int magAtk;
        public int phyDef;
        public int magDef;
        public int speed;
    }

    //add a prefeb here
    //UI Stuff also add here

    public enum Faction
    {
        Ally = 0,
        Enemies = 1,
    }
}
