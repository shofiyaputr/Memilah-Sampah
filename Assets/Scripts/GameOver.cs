using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float timer = 0;

    void Start()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Data.score = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }

    void Update()
    {
        
    }
}
