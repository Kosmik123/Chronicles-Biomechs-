﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Battler : ScriptableObject
{
    public GameObject characterModel; //prefab
    public int elementId;
    public int professionId;

    [SerializeField]
    protected int baseAttack;
    [SerializeField]
    protected int baseDefence;
    [SerializeField]
    protected int baseMaxHealth;


    
    //public Skill specialSkills;

}

[System.Serializable]
public class Loot
{
    [System.Serializable]
    public class ItemLoot
    {
        public Object item; // TODO zmiana object na klasę Item 
        public float probability;
    }

    public int experience;
    public int gold;
    public ItemLoot[] items;
}
