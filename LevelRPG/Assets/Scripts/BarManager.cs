using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BarManager : MonoBehaviour
{
    public Bars[] barList;
    private int barcount;
    public void Awake()
    {
        
        foreach (Bars bar in barList)
        {
            barcount++;
            if (bar == null)
            {
                Debug.LogError($"bar #{barcount} is null");
                return;
            }

            bar.setSliderValue(100, true);
            Debug.Log($"{bar.name} bar initialized");

        }
    }

    public void setBarByName(string name, float value, bool setMax)
    {
        foreach(Bars bar in barList)
        {
            if(bar.name == name)
            {
                bar.setSliderValue(value, setMax);
            }
        }
    }
    public void setBarByName(string name, float value)
    {
        foreach (Bars bar in barList)
        {
            if (bar.name == name)
            {
                bar.setSliderValue(value, false);
            }
        }
    }

}
