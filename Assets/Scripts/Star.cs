using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public Constellation constellation;

    public bool isActive;
    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }
    private EventManager eventManager;

    void Start()
    {
        eventManager = GameObject.Find("EventSystem").GetComponent<EventManager>();
        eventManager.SetStarsText();
    }

    private void OnMouseDown()
    {
        if (EventManager.Stars > 0 && !isActive)
        {
            SetActive();
            eventManager.UpdateRemainingStarsText();
            constellation.DetectConstellationUnlocked();
        }
    }

    public void SetActive()
    {
        isActive = true;
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(1, 0.97f, 0.66f, 1);
    }
}
