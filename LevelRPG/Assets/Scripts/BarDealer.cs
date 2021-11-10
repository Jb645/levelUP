using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarDealer : MonoBehaviour
{
    public BarManager BarManager;
    enum resourse
    {
        HP, MP
    } resourse currentResource = resourse.HP;

    public string resourceName => BarManager.barList[(int)currentResource].name;

    public void Switch()
    {
        switch (currentResource)
        {
            case resourse.HP:   
                currentResource = resourse.MP;
                
                break;
            default:
                currentResource = resourse.HP;
                break;
        }
        
    }

    public void dealDamage()
    {
        BarManager.setBarByName(resourceName,-10);
    }
    public void HealDamage()
    {
        
        BarManager.setBarByName(resourceName, +10);
    }

}
