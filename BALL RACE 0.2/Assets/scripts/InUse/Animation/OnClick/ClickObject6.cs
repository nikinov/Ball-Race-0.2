using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObject6 : MonoBehaviour
{
    public Player player;

    private void OnMouseDown()
    {
        player.UnlockS8();
    }
}
