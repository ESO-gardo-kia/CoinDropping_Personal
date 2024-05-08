using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float limit_time;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void GameStart()
    {
        SceneManager.LoadScene("Main");
    }
}
