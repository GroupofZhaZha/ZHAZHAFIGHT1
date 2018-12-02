using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class botMonsterController : MonoBehaviour {

    public static List<Monster> botList = new List<Monster>();

    public List<Monster> monsterList;
    // Use this for initialization
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
    public Text armor;
    public Text price;
    public Text health;

    public Text time;
    public Text gold;
    public int currentMoney;
    public int hp;
    public float timeLeft;

    void Start () {

        currentMoney = PlayerPrefs.GetInt("gold");
        timeLeft = PlayerPrefs.GetFloat("time");
        hp = PlayerPrefs.GetInt("hp");

        gold.alignment = TextAnchor.MiddleCenter;
        time.alignment = TextAnchor.MiddleCenter;
        time.text = "Time : " + timeLeft.ToString("f0") + "s";
        gold.text = "Gold : " + currentMoney.ToString();

        
        if (botList.Count==0){
            TextAsset monstertext = Resources.Load("monster", typeof(TextAsset)) as TextAsset;

            string[] data = monstertext.text.Split('\n');
            for (int i = 1; i < data.Length; ++i)
            {
                string[] row = data[i].Split(',');

                Monster m = new Monster(0, null, 0, 0, 0, 0, 0);

                int.TryParse(row[0], out m.id);
                m.monsterName = row[1];
                int.TryParse(row[2], out m.level);
                int.TryParse(row[3], out m.health);
                int.TryParse(row[4], out m.damage);
                int.TryParse(row[5], out m.armor);
                int.TryParse(row[6], out m.price);

                monsterList.Add(m);
            }

            Random r = new Random();

            int numberOfMonster = Random.Range(1,6);

            for (int i = 0; i < numberOfMonster;++i){

                botList.Add(monsterList[Random.Range(0, 5)]);
                print("Bot Count : " + botList.Count);
            }
        }

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

        for (int i = 0; i < botList.Count; i++)
        {
            Monster x = botList[i];
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
            else if (x.monsterName == "Robotman")
            {
                list[i].sprite = fourthImage;
            }
            else if (x.monsterName == "PClock")
            {
                list[i].sprite = fifthImage;
            }
        }
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f)
        {
            SceneManager.LoadScene("Battlefield");
            PlayerPrefs.SetFloat("time", timeLeft);
        }
        time.text = "Time : " + timeLeft.ToString("f0") + "s";

    }


    // Update is called once per frame

    public void checkInformationButton1()
    {
        if (botList.Count > 0)
        {
            Monster currentMonster = botList[0];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
        }
    }
    public void checkInformationButton2()
    {
        if (botList.Count > 1)
        {
            Monster currentMonster = botList[1];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
        }
    }
    public void checkInformationButton3()
    {
        if (botList.Count > 2)
        {
            Monster currentMonster = botList[2];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
        }
    }
    public void checkInformationButton4()
    {
        if (botList.Count > 3)
        {
            Monster currentMonster = botList[3];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
        }
    }
    public void checkInformationButton5()
    {
        if (botList.Count > 4)
        {
            Monster currentMonster = botList[4];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
        }
    }
    public void checkInformationButton6()
    {
        if (botList.Count > 5)
        {
            Monster currentMonster = botList[5];
            n.text = "Name : " + currentMonster.monsterName;
            level.text = "Lv : " + currentMonster.level.ToString();
            damage.text = "Damage : " + currentMonster.damage.ToString();
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
        }
    }

    public void backToGame(){
        SceneManager.LoadScene("Game");
    }

    public static void resetBotMonster(){
        botList = new List<Monster>();
    }
}
