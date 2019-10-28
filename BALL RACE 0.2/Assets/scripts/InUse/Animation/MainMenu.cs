using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator panel;
    [SerializeField] private Animator cam;

    public bool NotFirstTim;

    private void Update()
    {
        panel.SetBool("NotFirstTime", NotFirstTim);
    }
    private void Awake()
    {
        NotFirstTim = true;
    }
}
