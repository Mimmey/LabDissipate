using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    public float Tme = 0f;
    public Button TimeClick;
    bool Click = false;
    int afterdot = 1;
    void Start()
    {
        text = GetComponent<Text>();
        TimeClick.onClick.AddListener(StartTimer);
    }

    // Update is called once per frame
    void Update()
    {
        if (Click)
        {
            if (Tme < 9.9f) { afterdot = 2; } else { afterdot = 1; }
            Tme += Time.deltaTime;
            text.text = "Секундомер - " + System.Math.Round(Tme,afterdot) + " с.";
            if (Tme > 99) { Tme = 0; }
        }
    }

    void StartTimer()
    {
        Click = !Click;
    }
}
