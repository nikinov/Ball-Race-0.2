﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator storeAnime;
    [SerializeField] private Animator Play;
    [SerializeField] private Animator Pay;

    public int SkinNum;
    public int Buttons;

    public Player player;
    bool unlocked;

    GameObject ground;

    public void Start()
    {
        ground = GameObject.Find("Ground");
        player = ground.GetComponent<Player>();
    }
    public void Update()
    {
        unlocked = player.Unlocked;
        if (unlocked is true)
        {

        }

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
            if (unlocked is true)
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
            if (unlocked is true)
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
            if (unlocked is true)
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
            if (unlocked is true)
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
            if (unlocked is true)
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
            if (unlocked is true)
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
            if (unlocked is true)
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
            if (unlocked is true)
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
            if (unlocked is true)
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
