using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JustNumbers : MonoBehaviour
{
    public Player player;

    float HighScoreUp;
    int CashUP;

    private string Scoring;
    private string Cashing;

    [SerializeField]

    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSe2S47nxg4wYiIBVtG-ecuOSUb4xUDDrdvc1dWi1SpFWL_G4A/formResponse";

    private void Start()
    {
        HighScoreUp = player.HighScore;
        CashUP = player.Cash;
        HighScoreUp = Mathf.Round(HighScoreUp * 100) / 100;
        Scoring = HighScoreUp.ToString("");
        Cashing = CashUP.ToString("");

        Send();
    }
    public void Send ()
    {
        StartCoroutine(Post(Scoring, Cashing));
    }
    IEnumerator Post(string scoring, string cashing)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.665749733", scoring);
        form.AddField("entry.59448164", cashing);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }
}
