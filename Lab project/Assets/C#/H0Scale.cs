using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H0Scale : MonoBehaviour
{
    public Transform ball;
    public Slider slider;
    public float h0 = 0;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        h0 = slider.value/100;
        ball.position = new Vector2(ball.position.x, h0);
        text.text = "h0: "+h0*100+" см";
    }
}
