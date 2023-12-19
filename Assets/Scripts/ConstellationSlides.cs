using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstellationSlides : MonoBehaviour
{
    public int slideNumber;
    public GameObject[] slides;

    public void NextSlide()
    {
        if(slideNumber < slides.Length - 1) 
        {
            slides[slideNumber].SetActive(false);
            slideNumber++;
            slides[slideNumber].SetActive(true);
        }
    }

    public void PreviousSlide()
    {
        if(slideNumber > 0)
        {
            slides[slideNumber].SetActive(false);
            slideNumber--;
            slides[slideNumber].SetActive(true);
        }
    }
}
