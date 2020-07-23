using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    float getN(float pLiq, float temp) {
        int code = (int)temp * 1000 + (int)pLiq;
        switch (code) 
        {
            case 1260:
                return 12100f;
                break;
            case 11260:
                return 3950f;
                break;
            case 21260:
                return 1490f;
                break;
            case 31260:
                return 630f;
                break;
            case 41260:
                return 330f;
                break;
            case 51260:
                return 180f;
                break;
            case 1220:
                return 6500f;
                break;
            case 11220:
                return 2140f;
                break;
            case 21220:
                return 802f;
                break;
            case 31220:
                return 353f;
                break;
            case 41220:
                return 170f;
                break;
            case 51220:
                return 97f;
                break;
            /*case 876:
                return 0.910f;
                break;
            case 10876:
                return 0.755f;
                break;
            case 20876:
                return 0.652f;
                break;
            case 30876:
                return 0.559f;
                break;
            case 40876:
                return 0.503f;
                break;
            case 50876:
                return 0.436f;
                break;
            case 997:
                return 1.792f;
                break;
            case 10997:
                return 1.308f;
                break;
            case 20997:
                return 1.002f;
                break;
            case 30997:
                return 0.801f;
                break;
            case 40997:
                return 0.656f;
                break;
            case 50997:
                return 0.549f;
                break;
            */
            default:
                return 0;
        }
    }

    float temp = 0;
    float mass = 0;
    float h0 = 0;
    float pBall = 0;
    float pLiq = 0;
    public Rigidbody2D ball;
    public Transform Ball;
    public Dropdown Deoppball;
    public Dropdown Droppliq;
    public H0Scale h0scale;
    public Slider h0Slider;
    public Slider massSlider;
    public Slider tempSlider;
    public RoBall roball;
    public RoWater rowater;
    float NewY = 0;
    float time = 0;
    bool first = true;
 

    Button thisButton;
    void Start()
    {
        thisButton = gameObject.GetComponent<Button>();
        thisButton.onClick.AddListener(WasClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(first && Ball.position.y <= -0.001) {ball.gravityScale = 0; first = false;}
        if (Ball.position.y <= 0)
        {
            //место для скрипта движения в масле.
            float n = getN(pLiq, temp) * 0.001f;

            float r = (float)Math.Pow(mass * 0.75f / (float)Math.PI / pBall, 0.333333f);
            float alpha = 6 * (float)Math.PI * n * r / mass;
            float geff = 9.82f * (1 - (pLiq / pBall));
            float v0 = (float)Math.Sqrt(2 * 9.82f * h0);

            time += Time.deltaTime;
            //NewY = -1 * (2.0f / 9.0f * r * r * (pBall - pLiq) / n * 9.82f);
            NewY = -1 * (v0 * (float)Math.Exp(-1 * alpha * time) + geff/alpha*(1 - (float)Math.Exp(-1 * alpha * time)));
            ball.velocity = new Vector2(0, NewY);
        }
        //Ball.transform.position = new Vector2(1.51f, Ball.position.y);
    }

    void WasClicked()
    {
        pLiq = rowater.pLiqid;
        pBall = roball.pBall;
        temp = tempSlider.value*10;
        mass = massSlider.value*0.000001f; //мг->кг
        h0 = h0Slider.value*0.01f; //см->м
        h0Slider.enabled = false;
        ball.GetComponent<Rigidbody2D>().simulated = true;
        h0scale.enabled = false;
        massSlider.enabled = false;
        tempSlider.enabled = false;
        Deoppball.enabled = false;
        Droppliq.enabled = false;
        thisButton.enabled = false;
    }
}
