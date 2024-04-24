using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection_System : MonoBehaviour
{
    public PlayerController Player;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Coin"))
        {
            Player.residualCoin++;
            Destroy(collision.transform.gameObject);
        }
    }
}
