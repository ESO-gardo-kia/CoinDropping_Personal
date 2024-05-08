using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPushWallSystem : MonoBehaviour
{
    private float initialPoint;
    public  float movementRange;

    private float moved_distance;
    void Start()
    {
        initialPoint = transform.position.z;
    }
    void Update()
    {
        float past_coordinate = this.transform.position.z;
        transform.position = new Vector3(transform.position.x, transform.position.y, initialPoint + Mathf.Sin(Time.time) * movementRange);
        float current_coordinate = this.transform.position.z;
        moved_distance = past_coordinate - current_coordinate;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Coin"))
        {
            collision.transform.position += Vector3.forward * moved_distance;
        }
    }
}
