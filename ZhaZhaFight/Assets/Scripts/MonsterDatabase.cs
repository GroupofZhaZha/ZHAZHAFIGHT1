using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDatabase : MonoBehaviour {
    
    public static Transform[] monsters;


    private void Awake()
    {
        monsters = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            monsters[i] = transform.GetChild(i);
        }
    }
}
