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
    public int sell;
    public int goldUpgrade;

    public Monster(int _id, string _monsterName,int _level,int _damage,int _armor,int _health,int _price,int _sell,int _goldUpgrade)
    {
        id = _id;
        monsterName = _monsterName;
        level = _level;
        damage = _damage;
        health = _health;
        armor = _armor;
        price = _price;
        sell = _sell;
        goldUpgrade = _goldUpgrade;
    }
}
