using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;
public class myMonsterController : MonoBehaviour {

    // Use this for initialization
    public List<Monster> myMonster;
    public List<Monster> totalMonster;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
    public Sprite fourthImage;
    public Sprite fifthImage;

    public Sprite blinkImage;

    public List<Image> list;

    public Image img1;
    public Image img2;
    public Image img3;
    public Image img4;
    public Image img5;
    public Image img6;
    public Text n;
    public Text level;
    public Text damage;
    public Text health;
    public Text upgrader;
    public Text sellPrice;
    public Text time;
   
    public Text gold;
    public int currentMoney;
    public float timeLeft;
    public int hp;

    public GameObject canvas;
    public GameObject main;

    public Text alert;
    public static int currentLocation;
    public static Monster updateMonster;
    void Start () {
        alert.alignment = TextAnchor.MiddleCenter;
        canvas.SetActive(false);
        totalMonster = ButtonHandler.totalMonster;
        currentMoney = PlayerPrefs.GetInt("gold");
        timeLeft = PlayerPrefs.GetFloat("time");
        hp = PlayerPrefs.GetInt("hp");

        gold.alignment = TextAnchor.MiddleCenter;
        gold.text = "Gold : " + currentMoney.ToString();
        time.alignment = TextAnchor.MiddleCenter;
        time.text = "Time : " + timeLeft.ToString("f0") + "s";


        list = new List<Image>();
        list.Add(img1);
        list.Add(img2);
        list.Add(img3);
        list.Add(img4);
        list.Add(img5);
        list.Add(img6);

        list[0].sprite = blinkImage;
        list[1].sprite = blinkImage;
        list[2].sprite = blinkImage;
        list[3].sprite = blinkImage;
        list[4].sprite = blinkImage;
        list[5].sprite = blinkImage;

        currentLocation = -1;

        myMonster = wildMonsterController.ownList;
        //TextAsset monstertext = Resources.Load("ownList", typeof(TextAsset)) as TextAsset;
        //string[] data = monstertext.text.Split('\n');
        //print(data.Length);

        //for (int i = 0; i < data.Length; ++i)
        //{
        //    string[] row = data[i].Split(',');

        //    if (row[0]!="")
        //    {
        //        Monster m = new Monster(0, null, 0, 0, 0, 0, 0);
        //        int.TryParse(row[0], out m.id);
        //        m.monsterName = row[1];
        //        int.TryParse(row[2], out m.level);
        //        int.TryParse(row[3], out m.health);
        //        int.TryParse(row[4], out m.damage);
        //        int.TryParse(row[5], out m.armor);
        //        int.TryParse(row[6], out m.price);


        //        myMonster.Add(m);
        //    }
        //}                                         //Read data from ownList

        for(int i = 0; i < myMonster.Count; i++)
        {
            Monster x = myMonster[i];
            if (x.monsterName == "SickleDragon")
            {
                list[i].sprite = firstImage;
            }
            else if(x.monsterName == "SwordDragon")
            {
                list[i].sprite = secondImage;
            }
            else if(x.monsterName == "AxeDragon")
            {
                list[i].sprite = thirdImage;
            }
            else if(x.monsterName == "Robotman"){
                list[i].sprite = fourthImage;
            }
            else if(x.monsterName == "PClock"){
                list[i].sprite = fifthImage;
            }
        }
    }


    // Update is called once per frame
    void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f)
        {
            SceneManager.LoadScene("Battlefield");
            PlayerPrefs.SetFloat("time", timeLeft);
        }
        time.alignment = TextAnchor.MiddleCenter;
        time.text = "Time : " + timeLeft.ToString("f0") + "s";

    }


    void insertImg(Image i,Sprite s)
    {
        i.sprite = s;
    }
    
    public void checkInformationButton1()
    {
        if (myMonster.Count > 0)
        {
            Monster currentMonster = myMonster[0];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            upgrader.text = "Upgrade Money : " + currentMonster.goldUpgrade.ToString();
            sellPrice.text = "Sell Price : " + currentMonster.sell.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
            currentLocation = 0;
        }
    }
    public void checkInformationButton2()
    {
        if (myMonster.Count > 1)
        {
            Monster currentMonster = myMonster[1];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            upgrader.text = "Upgrade Money : " + currentMonster.goldUpgrade.ToString();
            sellPrice.text = "Sell Price : " + currentMonster.sell.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
            currentLocation = 1;
        }
    }
    public void checkInformationButton3()
    {
        if (myMonster.Count > 2)
        {
            Monster currentMonster = myMonster[2];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            upgrader.text = "Upgrade Money : " + currentMonster.goldUpgrade.ToString();
            sellPrice.text = "Sell Price : " + currentMonster.sell.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
            currentLocation = 2;
        }
    }
    public void checkInformationButton4()
    {
        if (myMonster.Count > 3)
        {
            Monster currentMonster = myMonster[3];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            upgrader.text = "Upgrade Money : " + currentMonster.goldUpgrade.ToString();
            sellPrice.text = "Sell Price : " + currentMonster.sell.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
            currentLocation = 3;
        }
    }
    public void checkInformationButton5()
    {
        if (myMonster.Count > 4)
        {
            Monster currentMonster = myMonster[4];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            upgrader.text = "Upgrade Money : " + currentMonster.goldUpgrade.ToString();
            sellPrice.text = "Sell Price : " + currentMonster.sell.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
            currentLocation = 4;
        }
    }
    public void checkInformationButton6()
    {
        if (myMonster.Count > 5)
        {
            Monster currentMonster = myMonster[5];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            upgrader.text = "Upgrade Money : " + currentMonster.goldUpgrade.ToString();
            sellPrice.text = "Sell Price : " + currentMonster.sell.ToString();
            health.text = "Health : " + currentMonster.health.ToString();
            currentLocation = 5;
        }
    }

    public void sellMonsterButton()
    {
        if (currentLocation == -1) {
            Debug.Log("Repeat Sell");
        }
        else
        {
            updateMonster = myMonster[currentLocation];
            int money = PlayerPrefs.GetInt("gold") + myMonster[currentLocation].sell;
            currentMoney = money;
            PlayerPrefs.SetInt("gold", money);
            gold.text = "Gold : " + PlayerPrefs.GetInt("gold");
            //string[] s = File.ReadAllLines("Assets/Resources/ownList.txt");
            //string[] sub = new string[s.Length - 1];
            //for (int i = 0; i < s.Length; ++i)
            //{
            //    if (i < currentLocation)
            //    {
            //        sub[i] = s[i];
            //    }
            //    else if (i > currentLocation)
            //    {
            //        sub[i - 1] = s[i];
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //File.WriteAllLines("Assets/Resources/ownList.txt", sub);

            //AssetDatabase.ImportAsset("Assets/Resources/ownList.txt");

            for (int i = currentLocation; i < myMonster.Count-1;i++){
                myMonster[i] = myMonster[i + 1];
            }

            myMonster.RemoveAt(myMonster.Count - 1);

            for (int i = 0; i < myMonster.Count; i++)
            {
                Monster x = myMonster[i];
                if (x.monsterName == "SickleDragon")
                {
                    list[i].sprite = firstImage;
                }
                else if (x.monsterName == "SwordDragon")
                {
                    list[i].sprite = secondImage;
                }
                else if (x.monsterName == "AxeDragon")
                {
                    list[i].sprite = thirdImage;
                }
                else if (x.monsterName == "Robotman"){
                    list[i].sprite = fourthImage;
                }
                else if (x.monsterName == "PClock"){
                    list[i].sprite = fifthImage;
                }
            }

            list[myMonster.Count].sprite = blinkImage;
            //myMonster.Remove(myMonster[currentLocation]);

            currentLocation = -1;
        }

    }
    public void BackToGame(){
        PlayerPrefs.SetInt("gold", currentMoney);
        PlayerPrefs.SetFloat("time", timeLeft);
        PlayerPrefs.SetInt("hp", hp);
        SceneManager.LoadScene("Game");
    }


    public void upgrade(){
        updateMonster = myMonster[currentLocation];

        if (currentMoney >= myMonster[currentLocation].goldUpgrade){
            int money = PlayerPrefs.GetInt("gold") - myMonster[currentLocation].goldUpgrade;
            currentMoney = money;
            PlayerPrefs.SetInt("gold", money);
            gold.text = "Gold:" + money;
            int d = myMonster[currentLocation].id;
            int l = myMonster[currentLocation].level;


            if(l<18){
                for (int i = 0; i < totalMonster.Count; i++)
                {
                    if (totalMonster[i].level == (l + 1) && totalMonster[i].id == d)
                    {
                        myMonster[currentLocation] = totalMonster[i];
                        canvas.SetActive(true);
                        main.SetActive(false);
                        alert.text = "Upgrade Successful";
                        if (currentLocation == 0)
                        {
                            checkInformationButton1();
                        }
                        if (currentLocation == 1)
                        {
                            checkInformationButton2();
                        }
                        if (currentLocation == 2)
                        {
                            checkInformationButton3();
                        }
                        if (currentLocation == 3)
                        {
                            checkInformationButton4();
                        }
                        if (currentLocation == 4)
                        {
                            checkInformationButton5();
                        }
                        if (currentLocation == 5)
                        {
                            checkInformationButton6();
                        }
                        break;
                    }
                }
            }
            else
            {
                alert.text = "You Monster Is Full Level";
                canvas.SetActive(true);
                main.SetActive(false);
            }
        }
        else{
            alert.text = "You don't have enough money to upgrade";
            canvas.SetActive(true);
            main.SetActive(false);
        }
    }
    public void okButton(){
        canvas.SetActive(false);
        main.SetActive(true);
    }
}
