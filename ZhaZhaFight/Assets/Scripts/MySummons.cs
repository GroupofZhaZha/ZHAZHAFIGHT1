using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySummons : MonoBehaviour {

    public static Transform[] locations;
    public GameObject go;

    // Use this for initialization
    void Start()
    {
        locations = new Transform[transform.childCount];
        for (int i = 0; i < locations.Length; i++)
        {
            locations[i] = transform.GetChild(i);
            GameObject temp = go.transform.GetChild(1).gameObject;
            GameObject monster;
            if (temp.name.Equals("Sickledragon")|| temp.name.Equals("Sworddragon") || temp.name.Equals("AxeDragon"))
            {
                 monster = (GameObject)Instantiate(temp, locations[i].position, Quaternion.Euler(new Vector3(0, 0, 0)));
            } else if (temp.name.Equals("PClock"))
            {
                monster = (GameObject)Instantiate(temp, locations[i].position, Quaternion.Euler(new Vector3(0, 90, 0)));
            }
            else
            {
                monster = (GameObject)Instantiate(temp, locations[i].position, locations[i].rotation);
            }
       
            monster.transform.localScale = new Vector3(5f, 5f, 5f);
            monster.transform.tag = "Ally";
            monster.AddComponent<MyMonster>();
        }

    }
}
