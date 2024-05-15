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
    public float throwDirection;
    public Vector2 throwDiffusionRange;

    public int residualCoin;
    public Text residualCoinText;
    void Start()
    {
        
    }
    void Update()
    {
        if(throwDirection < throwRate) throwDirection += Time.deltaTime;
        residualCoinText.text = "ResidualCoin:" + residualCoin.ToString();
        if (Input.GetKey(KeyCode.Space) && residualCoin > 0 && throwRate < throwDirection)
        {
            Debug.Log("ƒRƒCƒ“”­ŽË");
            throwDirection = 0;
            residualCoin--;
            GameObject throwcoin = Instantiate(throwCoin,this.transform);
            throwcoin.GetComponent<Rigidbody>().AddForce(throwPower + Vector3.right * Random.Range(throwDiffusionRange.x, throwDiffusionRange.y),ForceMode.Impulse);
            throwcoin.transform.parent = null;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
    }
}
