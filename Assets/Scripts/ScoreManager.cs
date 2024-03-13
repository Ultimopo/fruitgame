using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    float multiplierCount = 1;
    float score;

    public TextMeshProUGUI multiplierCountText;
    public TextMeshProUGUI scoreText;


    public void updateScore()
    {
        multiplierCount = multiplierCount + 0.1f;
        score = score + 8 * multiplierCount;
        Mathf.Ceil(multiplierCount);
        Mathf.Ceil(score);
        multiplierCountText.text = multiplierCount.ToString();
        scoreText.text = score.ToString();
    }
    public void DeleteMultiplier()
    {
        multiplierCount = 1;
        multiplierCountText.text = multiplierCount.ToString();
    }
}
