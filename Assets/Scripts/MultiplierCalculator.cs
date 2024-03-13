using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierCalculator : MonoBehaviour
{
    public float maxValue;
    public float value;
    public MultiSlider slider;
    ScoreManager scoremanager;
    void Awake()
    {
        if (!scoremanager) scoremanager = GameObject.FindWithTag("ScoreManagement").GetComponent<ScoreManager>();
    }
    void Start()
    {
        value = 0;
        slider.setMaxValue(maxValue);
    }

    // Update is called once per frame
    void Update()
    {
        value -= Time.deltaTime;
        slider.SetValue(value);
        if (value < 0)
        {
            scoremanager.DeleteMultiplier();
        }
    }

    public void SaveMultiplier()
    {
        value = maxValue;
    }
}
