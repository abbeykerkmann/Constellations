using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnlockConstellation : MonoBehaviour
{
    public GameObject[] stars;

    private bool isUnlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DetectConstellationUnlocked()
    {
        foreach(GameObject star in stars)
        {
            UnlockStar unlockStar = star.GetComponent<UnlockStar>();
            if (!unlockStar.IsActive)
            {
                isUnlocked = false;
                return;
            }
        }
        isUnlocked = true;
    }
}
