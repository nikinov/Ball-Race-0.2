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

    public bool Skin3;
    public bool Skin4;
    public bool Skin5;
    public bool Skin6;
    public bool Skin7;
    public bool Skin8;
    public bool Skin9;
    public bool Skin10;
    public bool Skin11;

    public bool Unlocked;

    public int Cash;

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
        Skin3 = data.skin3;
        Skin4 = data.skin4;
        Skin5 = data.skin5;
        Skin6 = data.skin6;
        Skin7 = data.skin7;
        Skin8 = data.skin8;
        Skin9 = data.skin9;
        Skin10 = data.skin10;
        Skin11 = data.skin11;
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
    public void UnlockS3()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin3 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS4()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin4 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS5()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin5 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS6()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin6 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS7()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin7 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS8()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin8 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS9()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin9 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS10()
    {
        if (Cash - 200 >= 0)
        {
            Cash -= 200;
            Skin10 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void UnlockS11()
    {
        if (Cash - 2000 >= 0)
        {
            Cash -= 2000;
            Skin11 = true;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
}
