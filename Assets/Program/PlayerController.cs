using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject throwCoin;
    public float movementSpeed;
    public Vector3 throwPower;
    public float throwRate;
    private float numRate;
    public int residualCoin;
    public Text residualCoinText;
    void Start()
    {
        
    }
    void Update()
    {
        residualCoinText.text = "ResidualCoin:" + residualCoin.ToString();
        if (Input.GetKey(KeyCode.Space) && residualCoin > 0 && throwRate < numRate)
        {
            numRate = 0;
            residualCoin--;
            GameObject throwcoin = Instantiate(throwCoin,this.transform);
            throwcoin.GetComponent<Rigidbody>().AddForce(throwPower + Vector3.right * Random.Range(-4,4),ForceMode.Impulse);
            throwcoin.transform.parent = null;
        }
    }
    private void FixedUpdate()
    {
        numRate += 0.02f;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movementSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * movementSpeed;
        }
    }
}
