using UnityEngine;
using UnityEngine.UI;

public class CollectingCoins : MonoBehaviour
{
    public Player player;

    public GameObject PlayGuy;

    public GameObject This;

    public int CoinsCollected;

    public GameManager manager;

    private void Start()
    {
        This.SetActive(true);
        CoinsCollected = 0;
    }
    //void OnCollisionEnter(Collision collisionInfo)
    //{
    //    if (collisionInfo.collider == TheGuy)
    //    {
    //        This.SetActive(false);
    //        player.Add1Cash();
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        This.SetActive(false);
        player.Add1Cash();
        manager.yeGot += 1;
    }
}
