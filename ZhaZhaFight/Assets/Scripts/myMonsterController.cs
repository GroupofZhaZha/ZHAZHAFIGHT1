using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myMonsterController : MonoBehaviour {

    // Use this for initialization
    public List<Monster> myMonster;

    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;

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
    public Text armor;
    public Text price;

    void Start () {
        list = new List<Image>();
        list.Add(img1);
        list.Add(img2);
        list.Add(img3);
        list.Add(img4);
        list.Add(img5);
        list.Add(img6);

        myMonster = new List<Monster>();
        TextAsset monstertext = Resources.Load("ownList", typeof(TextAsset)) as TextAsset;
        string[] data = monstertext.text.Split('\n');
        print(data.Length);

        for (int i = 0; i < data.Length; ++i)
        {
            string[] row = data[i].Split(',');

            if (row[0] != "")
            {
                Monster m = new Monster(0, null, 0, 0, 0, 0, 0);
                int.TryParse(row[0], out m.id);
                m.monsterName = row[1];
                int.TryParse(row[2], out m.level);
                int.TryParse(row[3], out m.health);
                int.TryParse(row[4], out m.damage);
                int.TryParse(row[5], out m.armor);
                int.TryParse(row[6], out m.price);


                myMonster.Add(m);
            }
        }                                         //Read data from ownList

        for(int i = 0; i < myMonster.Count; i++)
        {
            Monster x = myMonster[i];
            if (x.monsterName == "Green")
            {
                list[i].sprite = firstImage;
            }
            else if(x.monsterName == "Blue")
            {
                list[i].sprite = secondImage;
            }
            else if(x.monsterName == "Red")
            {
                list[i].sprite = thirdImage;
            }
        }
    }


    // Update is called once per frame
    void Update () {
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
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
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
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
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
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
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
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
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
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
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
            armor.text = "Armor : " + currentMonster.armor.ToString();
            price.text = "Price : " + currentMonster.price.ToString();
            health.text = "Health: " + currentMonster.health.ToString();
        }
    }

}
