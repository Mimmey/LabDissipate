using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TempScale : MonoBehaviour
{
    // Start is called before the first frame update

    public Image fill;
    public Slider slider;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fill.color = new Color(0.9f + 0.002f * 10 * slider.value, 1 - 0.002f * 10 * slider.value, 1 - 0.002f * 10 * slider.value);
    }
}
