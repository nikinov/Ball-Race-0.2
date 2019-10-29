using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Cam2;

    public void SetAnim()
    {
        Cam2.SetActive(true);
        Cam.SetActive(false);
    }
    private void Awake()
    {
        Cam2.SetActive(false);
        Cam.SetActive(true);
    }
}
