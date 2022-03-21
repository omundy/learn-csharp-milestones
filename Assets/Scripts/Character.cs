using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Character : MonoBehaviour
{
    public string charName = "Me";
    public int health = 10;

    public Character(string setName, int setHealth)
    {
        charName = setName;
        health = setHealth;
    }

    public struct Weapon
    {
        public string weapName;
        public int damage;

        public Weapon(string setName, int setDamage)
        {
            weapName = setName;
            damage = setDamage;
        }
    }

    abstract public void PrintStatsInfo();

}

public class Paladin : Character
{
    public Weapon weapon;

    public Paladin(string setName, int setHealth, Weapon setWeapon) : base(setName, setHealth)
    {
        weapon = setWeapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.Log($"{charName} has {health} health points and a {weapon.weapName} that does {weapon.damage} points of damage");
    }
}
