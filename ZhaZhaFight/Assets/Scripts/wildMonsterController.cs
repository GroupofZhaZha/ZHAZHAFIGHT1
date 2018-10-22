using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;
public class wildMonsterController : MonoBehaviour {

    public Text monsterName;
    public Text monsterLevel;
    public Text monsterDamage;
    public Text monsterArmor;
    public Text monsterPrice;
    public Text monsterHealth;
    // Use this for initialization

    // Update is called once per frame
    public List<Monster> list;
    public Monster currentMonster;

    public GameObject gb;
    public Text AlertText;

    public Text goldText;
    public Text timeText;
    public Text hpText;
    public float timeLeft;
    public int currentMoney;
    public int hp;

    public static List<Monster> ownList; //After catch the monster the monster will add to this list, In the beginning is empty;
    public int currentId;


    void Start()
    {
        currentId = PlayerPrefs.GetInt("currentId");

        hp = PlayerPrefs.GetInt("hp");
        timeLeft = PlayerPrefs.GetFloat("time");
        currentMoney = PlayerPrefs.GetInt("gold");

        timeText.text = "Time : " + timeLeft.ToString("f0") + "s";
        goldText.text = "Gold : " + currentMoney.ToString();
        hpText.text = "HP : " + hp.ToString();

        list = new List<Monster>();
        ownList = new List<Monster>();

        gb.SetActive(false);


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


            list.Add(m);
            print(list.Count);
        }



    }
    void Update () {

        timeLeft -= Time.deltaTime;
        if(timeLeft<=0f){
            PlayerPrefs.SetFloat("time", timeLeft);
            SceneManager.LoadScene("Battlefield");
        }
        timeText.text = "Time : " + timeLeft.ToString("f0")+"s";

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject.tag == "monster1")
                {
                    currentMonster = list[0];

                    monsterName.text = "Name : " + currentMonster.monsterName;
                    monsterLevel.text = "Lv : " + currentMonster.level.ToString();
                    monsterDamage.text = "Damage : " + currentMonster.damage.ToString();
                    monsterArmor.text = "Armor : " + currentMonster.armor.ToString();
                    monsterPrice.text = "Price : " + currentMonster.price.ToString();
                    monsterHealth.text = "Health: " + currentMonster.health.ToString();
                    print("click Monster1");
                }
                else if(hit.collider.gameObject.tag == "monster2")
                {
                    currentMonster = list[1];

                    monsterName.text = "Name : " + currentMonster.monsterName;
                    monsterLevel.text = "Lv : " + currentMonster.level.ToString();
                    monsterDamage.text = "Damage : " + currentMonster.damage.ToString();
                    monsterArmor.text = "Armor : " + currentMonster.armor.ToString();
                    monsterPrice.text = "Price : " + currentMonster.price.ToString();
                    monsterHealth.text = "Health: " + currentMonster.health.ToString();
                    print("click Monster2");
                }
                else if(hit.collider.gameObject.tag == "monster3")
                {
                    currentMonster = list[2];

                    monsterName.text = "Name : " + currentMonster.monsterName;
                    monsterLevel.text = "Lv : " + currentMonster.level.ToString();
                    monsterDamage.text = "Damage : " + currentMonster.damage.ToString();
                    monsterArmor.text = "Armor : " + currentMonster.armor.ToString();
                    monsterPrice.text = "Price : " + currentMonster.price.ToString();
                    monsterHealth.text = "Health: " + currentMonster.health.ToString();
                    print("click Monster3");
                }
                else if(hit.collider.gameObject.tag=="monster4"){
                    currentMonster = list[3];

                    monsterName.text = "Name : " + currentMonster.monsterName;
                    monsterLevel.text = "Lv : " + currentMonster.level.ToString();
                    monsterDamage.text = "Damage : " + currentMonster.damage.ToString();
                    monsterArmor.text = "Armor : " + currentMonster.armor.ToString();
                    monsterPrice.text = "Price : " + currentMonster.price.ToString();
                    monsterHealth.text = "Health: " + currentMonster.health.ToString();
                    print("click Monster3");
                }
                else if(hit.collider.gameObject.tag=="monster5"){
                    currentMonster = list[4];

                    monsterName.text = "Name : " + currentMonster.monsterName;
                    monsterLevel.text = "Lv : " + currentMonster.level.ToString();
                    monsterDamage.text = "Damage : " + currentMonster.damage.ToString();
                    monsterArmor.text = "Armor : " + currentMonster.armor.ToString();
                    monsterPrice.text = "Price : " + currentMonster.price.ToString();
                    monsterHealth.text = "Health: " + currentMonster.health.ToString();
                    print("click Monster3");
                }
            }
        }
	}


    public void catchListener()
    {

        int totalMoney = PlayerPrefs.GetInt("gold") - currentMonster.price;

        if (totalMoney < 0)
        {
            gb.SetActive(true);
            AlertText.text = "No enough Money!!!!!";
        }
        else if (ownList.Count == 6)
        {
            gb.SetActive(true);
            AlertText.text = "Your Monster is Full!!!!!";
        }
        else
        {
            PlayerPrefs.SetInt("gold", totalMoney);
            goldText.text = "Gold : " + totalMoney.ToString();
            ownList.Add(currentMonster);
            writeData();
            currentId++;
            PlayerPrefs.SetInt("currentId", currentId);
            gb.SetActive(true);
            AlertText.text = "Catch Successful";
            currentMoney = totalMoney;

        }


    }
    
    void writeData()
    {
        string path = "Assets/Resources/ownList.txt";
        StreamWriter w = new StreamWriter(path, true);
        
        w.WriteLine(currentId.ToString()+","+currentMonster.monsterName+","+currentMonster.level.ToString()+","
                    +currentMonster.health.ToString()+","+currentMonster.damage.ToString()+","+currentMonster.armor.ToString()+","
                    +currentMonster.price.ToString()+",");
        w.Close();
        AssetDatabase.ImportAsset(path);
        TextAsset asset = Resources.Load("ownList",typeof(TextAsset)) as TextAsset;

        Debug.Log(asset.text);
    }

    public void backToGamePanel(){
        PlayerPrefs.SetFloat("time",timeLeft);
        PlayerPrefs.SetInt("gold", currentMoney);
        PlayerPrefs.SetInt("hp", hp);
        SceneManager.LoadScene("Game");

    }
}
