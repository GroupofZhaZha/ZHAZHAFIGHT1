using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySummons : MonoBehaviour {

    public static Transform[] locations;
    public GameObject go;

    // Use this for initialization
    void Start()
    {
        List<Monster> list = wildMonsterController.ownList;
        locations = new Transform[transform.childCount];
        for (int i = 0; i<list.Count; i++)
        {
            locations[i] = transform.GetChild(i);
            GameObject temp = findMonster(list[i].monsterName);
            Quaternion rotation = findRotation(list[i].monsterName);
            GameObject monster = (GameObject)Instantiate(temp, locations[i].position, rotation);
            setScale(list[i].monsterName, monster);
            monster.transform.tag = "Ally";
            monster.AddComponent<MyMonster>();
            monster.GetComponent<MyMonster>().healthpoint = list[i].health;
            monster.GetComponent<MyMonster>().MAXHEALTH = list[i].health;
            monster.GetComponent<MyMonster>().attack = list[i].damage;
            monster.GetComponent<MyMonster>().defense = list[i].armor;
        }

    }

    void setScale(string monsterName, GameObject monster)
    {
        if (monsterName.Equals("SickleDragon") || monsterName.Equals("SwordDragon") || monsterName.Equals("AxeDragon"))
        {
            monster.transform.localScale = new Vector3(2f, 2f, 2f);
        } else
        {
            monster.transform.localScale = new Vector3(5f, 5f, 5f);
        }
    }

    Quaternion findRotation(string monsterName){
        if(monsterName.Equals("SickleDragon")||monsterName.Equals("SwordDragon")||monsterName.Equals("AxeDragon")){
            return Quaternion.Euler(new Vector3(0f, 180f, 0f));
        } else if(monsterName.Equals("PClock")){
            return Quaternion.Euler(new Vector3(0f, -90f, 0f));
        } else {
            return Quaternion.Euler(new Vector3(0f,90f,0f));
        }
    }

    GameObject findMonster(string monsterName){
        for (int i = 0; i < go.transform.childCount;i++){
            if(go.transform.GetChild(i).name.Equals(monsterName)){
                return go.transform.GetChild(i).gameObject;
            }
        }
        return null;
    }
}
