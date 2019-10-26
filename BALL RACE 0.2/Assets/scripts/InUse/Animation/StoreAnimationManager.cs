using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator storeAnime;

    public int SkinNum;
    public bool Defaul;

    GameObject ground;
    Player player;

    public void Start()
    {
        ground = GameObject.Find("Ground");
        player = ground.GetComponent<Player>();
        Defaul = true;

    }
    public void Update()
    {
        storeAnime.SetInteger("SkinNumber", SkinNum);
        storeAnime.SetBool("Default", Defaul);

        if (player.BeachSkin == 0)
        {
            SkinNum = 0;
        }
        if (player.BeachSkin == 1)
        {
            SkinNum = 1;
        }
        if (player.BeachSkin == 2)
        {
            SkinNum = 2;
        }
        if (player.BeachSkin == 3)
        {
            SkinNum = 3;
        }
        if (player.BeachSkin == 4)
        {
            SkinNum = 4;
        }
        if (player.BeachSkin == 5)
        {
            SkinNum = 5;
        }
        if (player.BeachSkin == 6)
        {
            SkinNum = 6;
        }
        if (player.BeachSkin == 7)
        {
            SkinNum = 7;
        }
        if (player.BeachSkin == 8)
        {
            SkinNum = 8;
        }
        if (player.BeachSkin == 9)
        {
            SkinNum = 9;
        }
        if (player.BeachSkin == 10)
        {
            SkinNum = 10;
        }
        if (player.BeachSkin == 11)
        {
            SkinNum = 11;
        }
    }
}
