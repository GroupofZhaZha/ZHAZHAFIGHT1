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
    public static int currentGold;
    public List<Monster> currentMonsterList;
    public bool noEnough;
    void Start()
    {

        currentGold = PlayerPrefs.GetInt("gold");
        monsterListSize = wildMonsterController.ownList.Count;
        currentMonsterList = wildMonsterController.ownList;

        if(BattleEnding.lost==1){
            w = new StreamWriter(path, true);
            string s = index.ToString() + " : After a battle finish, AI lose the game and decrease HP. Expection " + PlayerPrefs.GetInt("aihp") + " HP. Actual : " + PlayerPrefs.GetInt("aihp") + " HP.";
            w.WriteLine(s);
            w.WriteLine("Expection is equal to the actual");
            w.WriteLine("");
            w.Close();
            AssetDatabase.ImportAsset(path);
            index++;
            BattleEnding.lost = -1;
        }
        else if(BattleEnding.lost==0){
            w = new StreamWriter(path, true);
            string s = index.ToString() + " : After a battle finish, Player lose the game and decrease HP. Expection " + PlayerPrefs.GetInt("hp") + " HP. Actual : " + PlayerPrefs.GetInt("hp") + " HP.";
            w.WriteLine(s);
            w.WriteLine("Expection is equal to the actual");
            w.WriteLine("");
            w.Close();
            AssetDatabase.ImportAsset(path);
            index++;
            BattleEnding.lost = -1;
        }
    }

    void Update()
    {
        if(BattleEnding.done){
            w = new StreamWriter(path, true);
            string s = index.ToString() + " : After a battle finish, increasing 1000 golds. Expection : " + currentGold + " Gold. Actual : " + PlayerPrefs.GetInt("gold") + " Gold.";
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
            BattleEnding.done = false;
        }
    }
    public void checkStartGameButtonTest(){

        //    w.WriteLine(currentId.ToString()+","+currentMonster.monsterName+","+currentMonster.level.ToString()+","
        //                +currentMonster.health.ToString()+","+currentMonster.damage.ToString()+","+currentMonster.armor.ToString()+","
        //                +currentMonster.price.ToString()+",");
        //    w.Close();
        //    AssetDatabase.ImportAsset(path);
        noEnough = false;
        monsterListSize = 0;
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
        if(monsterListSize < 6)
        {
            if (wildMonsterController.ownList.Count != monsterListSize)
            {
                w = new StreamWriter(path, true);

                monsterListSize += 1;
                string s = index.ToString() + " : After catch, number of monster in the list should increase. Expection : Has " + (monsterListSize).ToString() + " Monsters, Actual : Has "
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
            else{
                w = new StreamWriter(path, true);

                string s = index.ToString() + " : If no enough money, number of monster in the list should not be changed. Expection : Has " + (monsterListSize).ToString() + " Monsters, Actual : Has "
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
                noEnough = true;
            }
        }
    }
    public void afterCatchMoneyTest(){
        if (monsterListSize <= 6)
        {
            if (!noEnough)
            {
                w = new StreamWriter(path, true);

                currentGold -= wildMonsterController.ownList[wildMonsterController.ownList.Count - 1].price;
                string s = index.ToString() + " : After catch the money of your own should decrease. Expection : Has " + currentGold.ToString() + " Gold, " +
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
            else{
                w = new StreamWriter(path, true);

                string s = index.ToString() + " : If the no enough money , the money after clicking catch should not be changed. Expection : Has " + currentGold.ToString() + " Gold, " +
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
     }

    public void fullAfterCatch()
    {
        if (monsterListSize == 6)
        {

        
        w = new StreamWriter(path, true);

            string s = index.ToString() + " : Monster List Is Full. Expection : Has " + 6 + " Monsters, and " + currentGold + " Gold, "+
                            "Actual : Has "+monsterListSize + " Monsters, and "+PlayerPrefs.GetInt("gold") + " Gold.";
            w.WriteLine(s);
            if (currentGold == PlayerPrefs.GetInt("gold")&&monsterListSize==6)
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

    public void sellTest(){
        w = new StreamWriter(path, true);

        monsterListSize -= 1;
        Monster m = myMonsterController.updateMonster;
        currentGold += m.sell;
        string s = index.ToString() + " : After Sell, number of monster in the list should decrease one. Expection : Has " + (monsterListSize).ToString() + " Monsters, and " + currentGold.ToString() + " Golds. Actual : Has "
                        + wildMonsterController.ownList.Count.ToString() + " Monsters, and "+PlayerPrefs.GetInt("gold")+" Gold.";
        w.WriteLine(s);
        if ((monsterListSize) == wildMonsterController.ownList.Count && currentGold == PlayerPrefs.GetInt("gold"))
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


    public void upgradeMonsterTest(){
        w = new StreamWriter(path, true);
        Monster m = myMonsterController.updateMonster;
        if(currentGold < m.goldUpgrade){ 
            string s = index.ToString() + " : Click Upgrade button and don't have enough money the gold should keep same. Expection : Has " + currentGold.ToString() + " Gold, " +
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
        else{
            currentGold -= m.goldUpgrade;
            string s = index.ToString() + " : Click Upgrade button to upgrade monster, the gold will decrease and monster's level up. Expection : Has " + currentGold.ToString() + " Gold, " + 
                            (m.level+1).ToString() + " Level. Actual : Has " + PlayerPrefs.GetInt("gold")+" Gold, "+wildMonsterController.ownList[myMonsterController.currentLocation].level +" Level";
            w.WriteLine(s);
            if ((currentGold == PlayerPrefs.GetInt("gold"))&& (m.level+1) == wildMonsterController.ownList[myMonsterController.currentLocation].level){
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



}
