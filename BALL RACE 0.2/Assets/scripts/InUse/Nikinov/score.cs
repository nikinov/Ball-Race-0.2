using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform pllayer;
    public Text scoreText;
    public Text scoreFinal;
    public float Score;
    public GameObject Deth;
    public Text Timeing;
    float timer;
    public Player player;

    public List<float> times;
    public float[] timings;

    int NumOfTimes;
    float PreScore = 1;

    private void Start()
    {
        //player.LoadHighScore();
        times = new List<float>();
        times.Add(1f);
    }
    void Update()
    {
        Score = pllayer.position.z;
        Score = Mathf.Round(Score * 1f);
        scoreText.text = Score.ToString("");

        timer += 1f * Time.deltaTime;

        if (Deth == true)
        {
            if (player.HighSacore < Score)
            {
                player.HighSacore = Score;
            }
            scoreFinal.text = Score.ToString("");
            Timeing.text = timer.ToString("F2");
            timings = times.ToArray();
            player.MakeTimeText();
        }
        TimePerScore();
    }
    public void TimePerScore ()
    {
        if (PreScore * 10 == Score)
        {
            times.Add(timer);
            NumOfTimes += 1;
            PreScore = PreScore * 10;
            times[NumOfTimes] = timer;

            Debug.Log(times[NumOfTimes]);
        }
    }
}
