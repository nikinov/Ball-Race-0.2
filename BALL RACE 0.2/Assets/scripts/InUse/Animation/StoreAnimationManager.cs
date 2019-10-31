using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator storeAnime;
    [SerializeField] private Animator Play;
    [SerializeField] private Animator Pay;

    public int SkinNum;
    public int Buttons;

    public Player player;
    bool skin3;
    bool skin4;
    bool skin5;
    bool skin6;
    bool skin7;
    bool skin8;
    bool skin9;
    bool skin10;
    bool skin11;

    int TheMonee;

    GameObject ground;

    public Text Lit;

    public void Start()
    {
        ground = GameObject.Find("Ground");
        player = ground.GetComponent<Player>();
    }
    public void Update()
    {
        TheMonee = player.Cash;
        Lit.text = TheMonee.ToString("");
        skin3 = player.Skin3;
        skin4 = player.Skin4;
        skin5 = player.Skin5;
        skin6 = player.Skin6;
        skin7 = player.Skin7;
        skin8 = player.Skin8;
        skin9 = player.Skin9;
        skin10 = player.Skin10;
        skin11 = player.Skin11;

        storeAnime.SetInteger("SkinNumber", SkinNum);
        Play.SetInteger("Buttons", Buttons);
        Pay.SetInteger("Buttons", Buttons);

        if (player.BeachSkin == 0)
        {
            SkinNum = 0;
            Buttons = 0;
        }
        if (player.BeachSkin == 1)
        {
            SkinNum = 1;
            Buttons = 0;
        }
        if (player.BeachSkin == 2)
        {
            SkinNum = 2;
            Buttons = 0;
        }
        if (player.BeachSkin == 3)
        {
            SkinNum = 3;
            if (skin3 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 4)
        {
            SkinNum = 4;
            if (skin4 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 5)
        {
            SkinNum = 5;
            if (skin5 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 6)
        {
            SkinNum = 6;
            if (skin6 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 7)
        {
            SkinNum = 7;
            if (skin7 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 8)
        {
            SkinNum = 8;
            if (skin8 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 9)
        {
            SkinNum = 9;
            if (skin9 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 10)
        {
            SkinNum = 10;
            if (skin10 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
        if (player.BeachSkin == 11)
        {
            SkinNum = 11;
            if (skin11 is true)
            {
                Buttons = 0;
            }
            else
            {
                Buttons = 1;
            }
        }
    }
}
