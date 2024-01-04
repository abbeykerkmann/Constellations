using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstellationManager : MonoBehaviour
{
    public static ConstellationManager Instance;

    private int stars;
    public int Stars
    {
        get { return stars; }
        set { stars = value; }
    }

    private int pointsPerStar = 1;
    public int PointsPerStar
    {
        get { return pointsPerStar; }
        set { pointsPerStar = value; }
    }

    public List<string> unlockedConstellations;
    public List<string> unlockedStars;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
