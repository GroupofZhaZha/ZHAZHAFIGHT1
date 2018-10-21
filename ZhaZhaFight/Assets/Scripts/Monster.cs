using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    public int id;
    public string monsterName;
    public int level;
    public int damage;
    public int health;
    public int armor;
    public int price;

    public Monster(int _id, string _monsterName,int _level,int _damage,int _armor,int _health,int _price)
    {
        id = _id;
        monsterName = _monsterName;
        level = _level;
        damage = _damage;
        health = _health;
        armor = _armor;
        price = _price;
    }
}
