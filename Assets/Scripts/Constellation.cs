using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Constellation : MonoBehaviour
{
    public string constellationName;
    public Star[] stars;
    public bool isUnlocked;
    public TextMeshProUGUI constellationText;

    private void Start()
    {
        bool unlocked = ConstellationManager.Instance.unlockedConstellations.Contains(constellationName);
        if (unlocked)
        {
            SetStarsUnlocked();
        }
        else
        {
            List<string> unlockedConstellationStars = ConstellationManager.Instance.unlockedStars.Where(s  => s.Contains(constellationName)).ToList();
            if (unlockedConstellationStars.Count > 0)
            {
                foreach (string star in unlockedConstellationStars)
                {
                    int index = Int32.Parse(star.Substring(constellationName.Length));
                    stars[index].SetActive();
                }
            }
        }
    }

    public void DetectConstellationUnlocked()
    {
        int activeStarCount = 0;
        for (int i = 0; i < stars.Length; i++)
        {
            if (stars[i].IsActive)
            {
                activeStarCount++;
                if (!ConstellationManager.Instance.unlockedStars.Contains(constellationName + i))
                {
                    ConstellationManager.Instance.unlockedStars.Add(constellationName + i);
                }
            }
        }
        if (activeStarCount == stars.Length)
        {
            isUnlocked = true;
            ConstellationManager.Instance.unlockedConstellations.Add(constellationName);
            ConstellationManager.Instance.unlockedStars.RemoveAll(s => s.Contains(constellationName));
            PowerUp.SelectPowerUp(constellationName);
        }
    }

    private void SetStarsUnlocked()
    {
        foreach (Star star in stars)
        {
            star.SetActive();
        }
    }
}
