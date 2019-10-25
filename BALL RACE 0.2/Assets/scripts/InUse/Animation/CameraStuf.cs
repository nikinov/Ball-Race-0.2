using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStuf : MonoBehaviour
{
    public GameObject canv;

    private void Start()
    {
        canv.SetActive(false);
    }
    public void SetCanf ()
    {
        canv.SetActive(false);
    }
    public void SetCant()
    {
        canv.SetActive(true);
    }
}
