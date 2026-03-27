using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTextUI;

    private int currentScore = 0;
    
    public void AddScore(int points)
    {
        currentScore += points;
        scoreTextUI.text = "Score: " + currentScore;
    }
}