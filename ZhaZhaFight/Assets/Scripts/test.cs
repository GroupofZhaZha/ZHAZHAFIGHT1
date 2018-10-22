using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

    public int gold;
    public float time;
    public int hp;
    public string path = "Assets/Resources/test.txt";
    public StreamWriter w;
    public static int index = 1;

    public int monsterListSize;
    public int currentGold;
    public List<Monster> currentMonsterList;
    void Start()
    {

        currentGold = PlayerPrefs.GetInt("gold");
        monsterListSize = wildMonsterController.ownList.Count;
        currentMonsterList = wildMonsterController.ownList;

    }
    public void checkStartGameButtonTest(){

        //    w.WriteLine(currentId.ToString()+","+currentMonster.monsterName+","+currentMonster.level.ToString()+","
        //                +currentMonster.health.ToString()+","+currentMonster.damage.ToString()+","+currentMonster.armor.ToString()+","
        //                +currentMonster.price.ToString()+",");
        //    w.Close();
        //    AssetDatabase.ImportAsset(path);
        w = new StreamWriter(path, true);

        string s = index.ToString()+" : Start Game . Expection : Gold - 2000, HP - 30, Time - 20s . Actual : Gold - " +
            PlayerPrefs.GetInt("gold") + ", HP - " + PlayerPrefs.GetInt("hp") + ", Time - " + PlayerPrefs.GetFloat("time").ToString("f0") + "s.";

        w.WriteLine(s);
        s = "";
        if(PlayerPrefs.GetInt("gold")==2000){
            s += "Gold Match, ";
        }
        else{
            s += "Gold Does not Match, ";
        }
        if(PlayerPrefs.GetInt("hp")==30){
            s += "HP Match, ";
        }
        else{
            s += "HP Does not Match.";
        }
        if(PlayerPrefs.GetFloat("time").ToString("f0")=="20"){
            s += "Time Match, ";
        }
        else{
            s += "Time Does not Match.";
        }
        w.WriteLine(s);
        w.WriteLine("");
        w.Close();
        AssetDatabase.ImportAsset(path);
        index++;
    }

    public void catchTest(){
        w = new StreamWriter(path, true);

        monsterListSize += 1;
        string s = index.ToString() + " : After catch, number of monster in the list . Expection : Has " + (monsterListSize).ToString() + " Monsters, Actual : Has "
                        + wildMonsterController.ownList.Count.ToString() + " Monsters";
        w.WriteLine(s);
        if((monsterListSize)==wildMonsterController.ownList.Count){
            w.WriteLine("Expection is equal to the actual");
        }
        else{
            w.WriteLine("Expection Failed");
        }
        w.WriteLine("");
        w.Close();
        AssetDatabase.ImportAsset(path);
        index++;
    }
    public void afterCatchMoneyTest(){
        w = new StreamWriter(path, true);

        currentGold -= wildMonsterController.ownList[wildMonsterController.ownList.Count - 1].price;
        string s = index.ToString() + " : After catch the money of your own. Expection : Has " + currentGold.ToString() + " Gold, " +
                        "Actual : Has " + PlayerPrefs.GetInt("gold");
        w.WriteLine(s);
        if(currentGold == PlayerPrefs.GetInt("gold")){
            w.WriteLine("Expection is equal to the actual");
        }
        else{
            w.WriteLine("Expection Failed");
        }
        w.WriteLine("");
        w.Close();
        AssetDatabase.ImportAsset(path);
        index++;
     }

    public void sellTest(){
        w = new StreamWriter(path, true);

        monsterListSize -= 1;
        string s = index.ToString() + " : After Sell, number of monster in the list . Expection : Has " + (monsterListSize).ToString() + " Monsters, Actual : Has "
                        + wildMonsterController.ownList.Count.ToString() + " Monsters";
        w.WriteLine(s);
        if ((monsterListSize) == wildMonsterController.ownList.Count)
        {
            w.WriteLine("Expection is equal to the actual");
        }
        else
        {
            w.WriteLine("Expection Failed");
        }
        w.WriteLine("");
        w.Close();
        AssetDatabase.ImportAsset(path);
        index++;
    }

    public void afterSellMoneyTest(){
        w = new StreamWriter(path, true);

        Monster m = new Monster(0,null,0,0,0,0,0);
        for (int i = 0; i < wildMonsterController.ownList.Count;++i){
            if(currentMonsterList[i]!=wildMonsterController.ownList[i]){
                m = currentMonsterList[i];
                break;
            }
        }
        if(m.monsterName==null){
            m = currentMonsterList[currentMonsterList.Count - 1];
        }
        currentGold = PlayerPrefs.GetInt("gold");
        string s = index.ToString() + " : After Sell the money of your own. Expection : Has " + currentGold + " Gold, " +
                        "Actual : Has " + PlayerPrefs.GetInt("gold");
        w.WriteLine(s);
        if (currentGold == PlayerPrefs.GetInt("gold"))
        {
            w.WriteLine("Expection is equal to the actual");
        }
        else
        {
            w.WriteLine("Expection Failed");
        }
        w.WriteLine("");
        w.Close();
        AssetDatabase.ImportAsset(path);
        index++;
    }


}
