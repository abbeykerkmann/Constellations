using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    private static int currentStars;

    private int stars = 10;
    public int Stars
    {
        get { return stars; }
        set { stars = value; }
    }

    private bool isGameActive;
    public bool IsGameActive
    {
        get { return isGameActive; }
        set { isGameActive = value; }
    }

    public TextMeshProUGUI starsText;
    public TextMeshProUGUI remainingStarsText;
    public GameObject gameOverMenu;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void RestartGame() 
    {
        Stars = 0;
        SceneManager.LoadScene(2);
    }

    public void ViewConstellations()
    {
        SceneManager.LoadScene(3);
    }

    public void UpdateStarsText()
    {
        Stars++;
        starsText.text = "Stars Collected: " + Stars;
    }

    public void UpdateRemainingStarsText()
    {
        Stars--;
        remainingStarsText.text = "Stars Left: " + Stars;
    }

    public void GameOver()
    {
        IsGameActive = false;
        gameOverMenu.SetActive(true);
    }
}
