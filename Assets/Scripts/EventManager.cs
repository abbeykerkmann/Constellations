using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    private bool isGameActive;
    public bool IsGameActive
    {
        get { return isGameActive; }
        set { isGameActive = value; }
    }

    private int currentStars = 0;
    public int CurrentStars
    {
        get { return currentStars; }
        set { currentStars = value; }
    }

    public TextMeshProUGUI newStarsText;
    public TextMeshProUGUI totalStarsText;
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
        CurrentStars = 0;
        SceneManager.LoadScene(2);
    }

    public void ViewConstellations()
    {
        SceneManager.LoadScene(3);
    }

    public void AddStar(int pointsPerStar)
    {
        CurrentStars += pointsPerStar;
        ConstellationManager.Instance.Stars += pointsPerStar;
        UpdateStarCounters();
    }

    public void SetStarsText()
    {
        remainingStarsText.text = "Stars Left: " + ConstellationManager.Instance.Stars;
    }

    public void SpendStar()
    {
        ConstellationManager.Instance.Stars--;
        remainingStarsText.text = "Stars Left: " + ConstellationManager.Instance.Stars;
    }

    public void GameOver()
    {
        IsGameActive = false;
        gameOverMenu.SetActive(true);
    }

    public void UpdateStarCounters()
    {
        newStarsText.text = "New Stars Collected: " + CurrentStars;
        totalStarsText.text = "Total Stars: " + ConstellationManager.Instance.Stars;
    }
}
