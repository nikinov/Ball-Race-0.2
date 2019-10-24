using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    GameObject BeachGreenSkin;
    GameObject BeachBlueSkin;
    GameObject BeachRedSkin;

    //Rigidbody GS;
    //Rigidbody BS;
    //Rigidbody RS;

    public int BeachSkin;

    private void Awake()
    {
        BeachGreenSkin = GameObject.FindGameObjectWithTag("BeachGreenSkin");
        BeachBlueSkin = GameObject.FindGameObjectWithTag("BeachBlueSkin");
        BeachRedSkin = GameObject.FindGameObjectWithTag("BeachRedSkin");
        //GS = BeachGreenSkin.GetComponent<Rigidbody>();
        //BS = BeachBlueSkin.GetComponent<Rigidbody>();
        //RS = BeachRedSkin.GetComponent<Rigidbody>();
        LoadData();
    }
    public void ToPlay ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    private void Update()
    {
        SaveData();
        if (BeachSkin == 0)
        {
            BeachGreenSkin.SetActive(true);
            BeachBlueSkin.SetActive(false);
            BeachRedSkin.SetActive(false);
        }
        if (BeachSkin == 1)
        {
            BeachGreenSkin.SetActive(false);
            BeachBlueSkin.SetActive(true);
            BeachRedSkin.SetActive(false);
        }
        if (BeachSkin == 2)
        {
            BeachGreenSkin.SetActive(false);
            BeachBlueSkin.SetActive(false);
            BeachRedSkin.SetActive(true);
        }
    }
    public void SaveData ()
    {
        SaveGame.saveData(this);
    }
    public void LoadData ()
    {
        GameData data = SaveGame.LoadData();

        BeachSkin = data.Pink;
    }
    public void Green ()
    {
        BeachSkin = 0;
    }
    public void Blue()
    {
        BeachSkin = 1;
    }
    public void Red()
    {
        BeachSkin = 2;
    }
}
