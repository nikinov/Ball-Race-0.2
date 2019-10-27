using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStuf : MonoBehaviour
{
    public GameObject canv;
    public bool PlayButton;
    public bool PayButton;

    private void Start()
    {
        canv.SetActive(false);
        PlayButton = false;
    }
    public void SetCanf ()
    {
        canv.SetActive(false);

    }
    public void SetCant()
    {
        canv.SetActive(true);
        PlayButton = false;
    }
}
