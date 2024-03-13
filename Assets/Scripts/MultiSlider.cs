using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MultiSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

    public void setMaxValue(float value)
    {
        slider.maxValue = value;
        slider.value = value;
    }
    public void SetValue(float value)
    {
        slider.value = value;
    }
}
