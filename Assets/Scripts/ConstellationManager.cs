using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstellationManager : MonoBehaviour
{
    public static ConstellationManager Instance;
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
