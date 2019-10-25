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
    }
}
