using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public static void SelectPowerUp(string constellationName)
    {
        switch (constellationName)
        {
            case "Aries":
                AriesPowerUp();
                break;
            case "Taurus":
                TaurusPowerUp();
                break;
            case "Gemini":
                GeminiPowerUp();
                break;
            case "Cancer":
                CancerPowerUp();
                break;
        }
    }

    public static void AriesPowerUp()
    {
        PlayerController.Speed = 15;
    }

    public static void TaurusPowerUp()
    {

    }

    public static void GeminiPowerUp() 
    {
        SpawnManager.StarDelay = 1.5f;
    }

    public static void CancerPowerUp()
    {
        PlayerController.PointsPerStar = 2;
    }
}
