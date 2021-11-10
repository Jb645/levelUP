using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Bars
{

    public Slider sliderBar;

    public string name;

    public TMP_Text slideText;

    

    public void setSliderValue(float value, bool SetMax)
    {
        
        if (!SetMax)
        {
            
            sliderBar.value += value;
            slideText.text = $"{name}:{sliderBar.value}";
            if (sliderBar.value <= 0)
            {
                Debug.Log($"You Ran Out of {name}");
            }
            return;
        }
        sliderBar.maxValue = value;
        sliderBar.value = value;
        slideText.text = $"{name}:{sliderBar.value}";
        Debug.Log($"{name} bar set to : {sliderBar.value}");
    }
}
