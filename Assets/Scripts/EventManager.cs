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
        ConstellationManager.Instance.Stars = 0;
        SceneManager.LoadScene(2);
    }

    public void ViewConstellations()
    {
        SceneManager.LoadScene(3);
    }

    public void AddStar(int pointsPerStar)
    {
        ConstellationManager.Instance.Stars += pointsPerStar;
        starsText.text = "Stars Collected: " + ConstellationManager.Instance.Stars;
    }

    public void SetStarsText()
    {
        remainingStarsText.text = "Stars Left: " + ConstellationManager.Instance.Stars;
    }

    public void UpdateRemainingStarsText()
    {
        ConstellationManager.Instance.Stars--;
        remainingStarsText.text = "Stars Left: " + ConstellationManager.Instance.Stars;
    }

    public void GameOver()
    {
        IsGameActive = false;
        gameOverMenu.SetActive(true);
    }
}
