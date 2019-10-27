using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    GameObject BeachGreenSkin;
    GameObject BeachBlueSkin;
    GameObject BeachRedSkin;
    GameObject AsphaltWhiteSkin;
    GameObject AsphaltGreenSkin;
    GameObject AsphaltBlueSkin;
    GameObject AsphaltRedSkin;
    GameObject AsphaltYellowSkin;
    GameObject AsphaltLiteBlueSkin;
    GameObject AsphaltPurpleSkin;
    GameObject AsphaltBlackSkin;
    GameObject SimpleGamesSkin;

    public bool Unlocked;

    //Rigidbody GS;
    //Rigidbody BS;
    //Rigidbody RS;

    public int BeachSkin;
    //public int SkNum;

    private void Awake()
    {
        BeachGreenSkin = GameObject.FindGameObjectWithTag("BeachGreenSkin");
        BeachBlueSkin = GameObject.FindGameObjectWithTag("BeachBlueSkin");
        BeachRedSkin = GameObject.FindGameObjectWithTag("BeachRedSkin");
        AsphaltWhiteSkin = GameObject.FindGameObjectWithTag("WhiteAsphaltSkin");
        AsphaltGreenSkin = GameObject.FindGameObjectWithTag("GreenAsphaltSkin");
        AsphaltBlueSkin = GameObject.FindGameObjectWithTag("BlueAsphaltSkin");
        AsphaltRedSkin = GameObject.FindGameObjectWithTag("RedAsphaltSkin");
        AsphaltYellowSkin = GameObject.FindGameObjectWithTag("YellowAsphaltSkin");
        AsphaltLiteBlueSkin = GameObject.FindGameObjectWithTag("LiteBlueAsphaltSkin");
        AsphaltPurpleSkin = GameObject.FindGameObjectWithTag("PurpleAsphaltSkin");
        AsphaltBlackSkin = GameObject.FindGameObjectWithTag("BlackAsphaltSkin");
        SimpleGamesSkin = GameObject.FindGameObjectWithTag("SimpleGamesSkin");
        //GS = BeachGreenSkin.GetComponent<Rigidbody>();
        //BS = BeachBlueSkin.GetComponent<Rigidbody>();
        //RS = BeachRedSkin.GetComponent<Rigidbody>();
        LoadData();
    }
    public void ToPlay ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void SetSkinsFalse()
    {
        BeachGreenSkin.SetActive(false);
        BeachBlueSkin.SetActive(false);
        BeachRedSkin.SetActive(false);
        AsphaltWhiteSkin.SetActive(false);
        AsphaltGreenSkin.SetActive(false);
        AsphaltBlueSkin.SetActive(false);
        AsphaltRedSkin.SetActive(false);
        AsphaltYellowSkin.SetActive(false);
        AsphaltLiteBlueSkin.SetActive(false);
        AsphaltPurpleSkin.SetActive(false);
        AsphaltBlackSkin.SetActive(false);
        SimpleGamesSkin.SetActive(false);
    }
    private void Update()
    {
        SaveData();
        if (BeachSkin < 0)
        {
            BeachSkin = 0;
        }
        if (BeachSkin > 11)
        {
            BeachSkin = 11;
        }
        if (BeachSkin == 0)
        {
            SetSkinsFalse();
            BeachGreenSkin.SetActive(true);
        }
        if (BeachSkin == 1)
        {
            SetSkinsFalse();
            BeachBlueSkin.SetActive(true);
        }
        if (BeachSkin == 2)
        {
            SetSkinsFalse();
            BeachRedSkin.SetActive(true);
        }
        if (BeachSkin == 3)
        {
            SetSkinsFalse();
            AsphaltWhiteSkin.SetActive(true);
        }
        if (BeachSkin == 4)
        {
            SetSkinsFalse();
            AsphaltGreenSkin.SetActive(true);
        }
        if (BeachSkin == 5)
        {
            SetSkinsFalse();
            AsphaltBlueSkin.SetActive(true);
        }
        SaveData();
        if (BeachSkin == 6)
        {
            SetSkinsFalse();
            AsphaltRedSkin.SetActive(true);
        }
        if (BeachSkin == 7)
        {
            SetSkinsFalse();
            AsphaltYellowSkin.SetActive(true);
        }
        if (BeachSkin == 8)
        {
            SetSkinsFalse();
            AsphaltLiteBlueSkin.SetActive(true);
        }
        if (BeachSkin == 9)
        {
            SetSkinsFalse();
            AsphaltPurpleSkin.SetActive(true);
        }
        if (BeachSkin == 10)
        {
            SetSkinsFalse();
            AsphaltBlackSkin.SetActive(true);
        }
        if (BeachSkin == 11)
        {
            SetSkinsFalse();
            SimpleGamesSkin.SetActive(true);
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
    public void right ()
    {
        if (BeachSkin <= 10)
        {
            BeachSkin += 1;
        }
    }
    public void Left ()
    {
        if (BeachSkin >= 1)
        {
            BeachSkin -= 1;
        }
    }
}
