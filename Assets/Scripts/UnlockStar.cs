using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockStar : MonoBehaviour
{
    private EventManager eventManager;
    public UnlockConstellation unlockConstellation;

    private bool isActive = false;
    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    void Start()
    {
        eventManager = GameObject.Find("EventSystem").GetComponent<EventManager>();
        eventManager.UpdateRemainingStarsText();
    }

    private void OnMouseDown()
    {
        if(eventManager.Stars > 0 && !isActive)
        {
            isActive = true;
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = new Color(1, 0.97f, 0.66f, 1);
            eventManager.UpdateRemainingStarsText();
            unlockConstellation.DetectConstellationUnlocked();
        }
    }
}
