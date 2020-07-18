using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassSlider : MonoBehaviour
{
    public Slider slider;
    public float m=0;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        m = slider.value;
        
        text.text = "Масса: " + m + "мг";
    }
}
