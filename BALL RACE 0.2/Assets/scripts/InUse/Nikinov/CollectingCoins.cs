using UnityEngine;
using UnityEngine.UI;

public class CollectingCoins : MonoBehaviour
{
    Player player;

    public GameObject This;

    public int CoinsCollected;

    GameManager manager;

    private void Start()
    {
        This.SetActive(true);
        CoinsCollected = 0;
    }
    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
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
