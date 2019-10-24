using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator storeAnime;

    public int SkinNum;

    private void Update()
    {
        storeAnime.SetInteger("SkinNumber", SkinNum);

        GameObject ground = GameObject.Find("Ground");
        Player player = ground.GetComponent<Player>();
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
