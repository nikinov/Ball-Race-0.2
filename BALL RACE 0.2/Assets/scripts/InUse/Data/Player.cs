using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public int Skin3;
    public int Skin4;
    public int Skin5;
    public int Skin6;
    public int Skin7;
    public int Skin8;
    public int Skin9;
    public int Skin10;
    public int Skin11;

    public bool Unlocked;

    public int Cash;
    public float HighScore;

    //Rigidbody GS;
    //Rigidbody BS;
    //Rigidbody RS;

    public int BeachSkin;
    //public int SkNum;
    public score Score;
    public float[] timing;
    //public List<float> SavedTimes;
    public List<float> NotSavedTimes;
    public Text timingText;
    public Text timingText0;
    public Text timingText1;
    public Text timingText2;
    public Text timingText3;
    public Text timingText4;
    public Text timingText5;
    public Text timingText6;
    public Text timingText7;
    public GameObject timingTextUI;
    public GameObject timingText0UI;
    public GameObject timingText1UI;
    public GameObject timingText2UI;
    public GameObject timingText3UI;
    public GameObject timingText4UI;
    public GameObject timingText5UI;
    public GameObject timingText6UI;
    public GameObject timingText7UI;

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
        LoadData2();
        timingTextUI.SetActive(false);
        timingText0UI.SetActive(false);
        timingText1UI.SetActive(false);
        timingText2UI.SetActive(false);
        timingText3UI.SetActive(false);
        timingText4UI.SetActive(false);
        timingText5UI.SetActive(false);
        timingText6UI.SetActive(false);
        timingText7UI.SetActive(false);
    }
    public void ToPlay()
    {
        SaveData2();
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void MakeTimeText()
    {
        if (NotSavedTimes.Count >= 2)
        {
            NotSavedTimes[1] = Mathf.Round(NotSavedTimes[1] * 100) / 100;
            timingText.text = NotSavedTimes[1].ToString("");
            timingTextUI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 3)
        {
            NotSavedTimes[2] = Mathf.Round(NotSavedTimes[2] * 100) / 100;
            timingText0.text = NotSavedTimes[2].ToString("");
            timingText0UI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 4)
        {
            NotSavedTimes[3] = Mathf.Round(NotSavedTimes[3] * 100) / 100;
            timingText1.text = NotSavedTimes[3].ToString("");
            timingText1UI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 5)
        {
            NotSavedTimes[4] = Mathf.Round(NotSavedTimes[4] * 100) / 100;
            timingText2.text = NotSavedTimes[4].ToString("");
            timingText2UI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 6)
        {
            NotSavedTimes[5] = Mathf.Round(NotSavedTimes[5] * 100) / 100;
            timingText3.text = NotSavedTimes[5].ToString("");
            timingText3UI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 7)
        {
            NotSavedTimes[6] = Mathf.Round(NotSavedTimes[6] * 100) / 100;
            timingText4.text = NotSavedTimes[6].ToString("");
            timingText4UI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 8)
        {
            NotSavedTimes[7] = Mathf.Round(NotSavedTimes[7] * 100) / 100;
            timingText5.text = NotSavedTimes[7].ToString("");
            timingText5UI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 9)
        {
            NotSavedTimes[8] = Mathf.Round(NotSavedTimes[8] * 100) / 100;
            timingText6.text = NotSavedTimes[8].ToString("");
            timingText6UI.SetActive(true);
        }
        if (NotSavedTimes.Count >= 10)
        {
            NotSavedTimes[9] = Mathf.Round(NotSavedTimes[9] * 100) / 100;
            timingText7.text = NotSavedTimes[9].ToString("");
            timingText7UI.SetActive(true);
        }
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
        NotSavedTimes = Score.times;
        timing = Score.timings;
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
        if (BeachSkin == 0)
        {
            SaveData2();
        }
        if (BeachSkin == 1)
        {
            SaveData2();
        }
        if (BeachSkin == 2)
        {
            SaveData2();
        }
        if (BeachSkin == 3)
        {
            if (Skin3 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 4)
        {
            if (Skin4 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 5)
        {
            if (Skin5 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 6)
        {
            if (Skin6 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 7)
        {
            if (Skin7 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 8)
        {
            if (Skin8 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 9)
        {
            if (Skin9 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 10)
        {
            if (Skin10 == 1)
            {
                SaveData2();
            }
        }
        if (BeachSkin == 11)
        {
            if (Skin11 == 1)
            {
                SaveData2();
            }
        }
    }
    //public void SaveData1()
    //{
    //    SaveGame.saveData(this);
    //}
    //public void LoadData1()
    //{
    //    GameData data = SaveGame.LoadData();

    //    BeachSkin = data.Pink;
    //    Skin3 = data.skin3;
    //    Skin4 = data.skin4;
    //    Skin5 = data.skin5;
    //    Skin6 = data.skin6;
    //    Skin7 = data.skin7;
    //    Skin8 = data.skin8;
    //    Skin9 = data.skin9;
    //    Skin10 = data.skin10;
    //    Skin11 = data.skin11;
    //    Cash = data.cash;
    //}
    public void SaveData2()
    {
        PlayerPrefs.SetInt("Pink", BeachSkin);
        PlayerPrefs.SetInt("skin3", Skin3);
        PlayerPrefs.SetInt("skin4", Skin4);
        PlayerPrefs.SetInt("skin5", Skin5);
        PlayerPrefs.SetInt("skin6", Skin6);
        PlayerPrefs.SetInt("skin7", Skin7);
        PlayerPrefs.SetInt("skin8", Skin8);
        PlayerPrefs.SetInt("skin9", Skin9);
        PlayerPrefs.SetInt("skin10", Skin10);
        PlayerPrefs.SetInt("skin11", Skin11);
        PlayerPrefs.SetInt("cash", Cash);
        PlayerPrefs.SetFloat("highScore", HighScore);
    }
    public void LoadData2()
    {
        BeachSkin = PlayerPrefs.GetInt("Pink");
        Skin3 = PlayerPrefs.GetInt("skin3");
        Skin4 = PlayerPrefs.GetInt("skin4");
        Skin5 = PlayerPrefs.GetInt("skin5");
        Skin6 = PlayerPrefs.GetInt("skin6");
        Skin7 = PlayerPrefs.GetInt("skin7");
        Skin8 = PlayerPrefs.GetInt("skin8");
        Skin9 = PlayerPrefs.GetInt("skin9");
        Skin10 = PlayerPrefs.GetInt("skin10");
        Skin11 = PlayerPrefs.GetInt("skin11");
        Cash = PlayerPrefs.GetInt("cash");
    }
    public void LoadHighScore2()
    {
        HighScore = PlayerPrefs.GetFloat("highScore");
    }
    //public void LoatTimeData()
    //{
    //    GameData data = SaveGame.LoadData();

    //    SavedTimes.AddRange(data.timis);
    //}
    //public void LoadHighScore1()
    //{
    //    GameData data = SaveGame.LoadData();

    //    HighSacore = data.highScore;
    //}
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
            Skin3 = 1;
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
            Skin4 = 1;
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
            Skin5 = 1;
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
            Skin6 = 1;
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
            Skin7 = 1;
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
            Skin8 = 1;
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
            Skin9 = 1;
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
            Skin10 = 1;
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
            Skin11 = 1;
        }
        else
        {
            Debug.Log("You Don't have enought cash");
        }
    }
    public void Add1Cash()
    {
        Cash += 1;
    }
}
