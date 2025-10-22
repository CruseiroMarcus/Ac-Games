using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;  

    public TMP_Text scoreText;  
    public TMP_Text gameOverText;  

    private void Start()
    {
        UpdateHUD();  

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);  
        }
    }

   
    public void AddPoints(int quantidade)
    {
        score += quantidade;
        UpdateHUD(); 
    }

   
    public void GameOver()
    {
        Debug.Log("Game Over!");

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);  
        }
    }

 
    public void UpdateHUD()
    {
        scoreText.text = "Pontos: " + score;  
    }
}
