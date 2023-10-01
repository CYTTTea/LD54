using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;


public class UIManager : MonoBehaviour
{
    public Text missingTouristsText; 

    public IntegerVariable Missing1;

    void Update()
    {

        if (missingTouristsText != null)
        {
            missingTouristsText.text = "Missing Tourists: " + CountManager.instance.missingTouristsCount.ToString();
            Missing1.Value = CountManager.instance.missingTouristsCount;
        }
    }
}
