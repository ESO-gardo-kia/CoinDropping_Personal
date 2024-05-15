using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectionSystem : MonoBehaviour
{
    [SerializeField]
    private PlayerController Player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Coin"))
        {
            Player.residualCoin++;
            Destroy(collision.transform.gameObject);
        }
    }
}
