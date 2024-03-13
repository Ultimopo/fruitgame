using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameoverText;
    public bool gameFailed;
    public bool somethingEnter;
    public float gameOverTime = 5;
    public int tagcomparer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameFailed = true;
    }
    void Update()
    {
        if (gameFailed)
        {
            gameOverTime -= Time.deltaTime;
            gameoverText.text = "Game Over";
        }
        
        if (gameOverTime < 0) SceneManager.LoadScene("Menu");
    }
}
