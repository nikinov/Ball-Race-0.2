using UnityEngine;
using System.Collections;

public class FollowPlayer1 : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Cam2;
    public GameObject SpeedoShower;
    public GameObject GamePanel;

    public void SetAnim()
    {
        Cam2.SetActive(true);
        Cam.SetActive(false);
        SpeedoShower.SetActive(true);
        GamePanel.SetActive(true);
    }
    private void Awake()
    {
        Cam2.SetActive(false);
        Cam.SetActive(true);
        SpeedoShower.SetActive(false);
        GamePanel.SetActive(false);
    }
}
