using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObject : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
