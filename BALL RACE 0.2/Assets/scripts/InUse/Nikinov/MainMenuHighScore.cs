using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuHighScore : MonoBehaviour
{
	public Player player;
	float HigScore;
    int OhYeh;
    public TextMeshPro Sctext;
    public TextMeshPro MoneyBay;

    void Start()
    {
        player.LoadHighScore();
        HigScore = player.HighSacore;
        HigScore = Mathf.Round(HigScore * 1);
        Sctext.text = HigScore.ToString("");

        OhYeh = player.Cash;
        MoneyBay.text = OhYeh.ToString("");
    }
}
