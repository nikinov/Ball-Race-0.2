using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonstuf : MonoBehaviour
{
    public GameObject LeftButton;
    public GameObject RightButton;
    public Player player;

    private void Update()
    {
        if (player.BeachSkin == 11)
        {
            RightButton.SetActive(false);
        }
        else
        {
            RightButton.SetActive(true);
        }
        if (player.BeachSkin == 0)
        {
            LeftButton.SetActive(false);
        }
        else
        {
            LeftButton.SetActive(true);
        }
    }
}
