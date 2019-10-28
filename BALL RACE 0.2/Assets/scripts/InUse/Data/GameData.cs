using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int cash;
    public int Pink;
    public bool skin3;
    public bool skin4;
    public bool skin5;
    public bool skin6;
    public bool skin7;
    public bool skin8;
    public bool skin9;
    public bool skin10;
    public bool skin11;
    //public float[] timis;
    private GameData playerData;
    private GameData player;

    public GameData (Player player)
    {
        cash = player.Cash;
        Pink = player.BeachSkin;
        skin3 = player.Skin3;
        skin4 = player.Skin4;
        skin5 = player.Skin5;
        skin6 = player.Skin6;
        skin7 = player.Skin7;
        skin8 = player.Skin8;
        skin9 = player.Skin9;
        skin10 = player.Skin10;
        skin11 = player.Skin11;
        //timis = player.timing;
    }
}
