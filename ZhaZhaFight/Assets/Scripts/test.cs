using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour {

    // Use this for initialization
    public string path;
    public StreamWriter w;
    public int hp;
    public float time;
    public int gold;
    void Start()
    {
        path = "Assets/Resources/test.txt";

    }
    public void testStartGame(){
        Invoke("subtestStartGame", 1f);
        subTestStartGame();
    }
    public void subTestStartGame(){
        StreamWriter w = new StreamWriter(path, true);
        string s = "";
        //if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Game")){
        s = "Enter to the Game Panel . Expect : HP - " + hp.ToString() + ", Time - " + time.ToString() + ", Gold - " + gold.ToString()
                                                               + ". Actual : HP - " + PlayerPrefs.GetInt("hp").ToString()
                                                               + ", Time - " + PlayerPrefs.GetFloat("time").ToString() + ", Gold - " + PlayerPrefs.GetInt("gold").ToString();
        w.WriteLine(s);
        w.WriteLine(informationMatch(""));
        w.Close();
        AssetDatabase.ImportAsset(path);
        //}
        //else{
        //    w.WriteLine("Does not Acceess Game Panel");
        //    w.Close();
        //    AssetDatabase.ImportAsset(path);
        //}
    }

    public string informationMatch(string s){
        if(hp==PlayerPrefs.GetInt("hp")&&(time==PlayerPrefs.GetFloat("time"))&&(gold==PlayerPrefs.GetInt("gold"))){
            s = "Information is Equal";
        }
        else{
            if(hp != PlayerPrefs.GetInt("hp")){
                s += "HP does not match . ";
            }
            if(time != PlayerPrefs.GetFloat("time")){
                s += "Time does not match . ";
            }
            if(gold != PlayerPrefs.GetInt("gold")){
                s += "Time does not match . ";
            }

        }
        return s;
    }
}
