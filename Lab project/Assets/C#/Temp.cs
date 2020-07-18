using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temp : MonoBehaviour
{
    public Slider slider;
    public float t = 0;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        t = slider.value;
        text.text = "Температура: " + 10 * t + " С°";
    }
}
