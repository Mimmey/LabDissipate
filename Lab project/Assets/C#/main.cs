using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    int getN(float pLiq, float temp) {
        int code = (int)Math.Round(temp * 1000) + (int)Math.Round(pLiq);
        switch (code) 
        {
            case 1260:
                return 12100;
                break;
            case 11260:
                return 3950;
                break;
            case 21260:
                return 1490;
                break;
            case 31260:
                return 630;
                break;
            case 41260:
                return 330;
                break;
            case 51260:
                return 180;
                break;
            case 1220:
                return 6500;
                break;
            case 11220:
                return 2140;
                break;
            case 21220:
                return 802;
                break;
            case 31220:
                return 353;
                break;
            case 41220:
                return 170;
                break;
            case 51220:
                return 97;
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
    

        if (first && Ball.position.y <= -0.001f) {ball.gravityScale = 0; first = false;}
        if (Ball.position.y <= 0)
        {
            //место для скрипта движения в масле.
            try
            {
                float n = getN(rowater.pLiqid, tempSlider.value * 10) * 0.001f;
                //print("n: " + n + "\n");
                float r = Convert.ToSingle(Math.Pow((massSlider.value * 0.000001f) * 0.75 / Math.PI / roball.pBall, 0.3333333));
                //print("r: " + r + "\n");
                float alpha = 6 * Convert.ToSingle(Math.PI) * n * r / (massSlider.value * 0.000001f);
                //print("alpha: " + alpha + "\n");
                float geff = 9.82f * (1 - (rowater.pLiqid / roball.pBall));
                //print("geff: " + geff + "\n");
                float v0 = Convert.ToSingle(Math.Pow(2 * 9.82f * (h0Slider.value * 0.01f), 0.5f));
                //print("v0: " + v0 + "\n");

                time += Time.deltaTime;
                //NewY = -1 * (2.0f / 9.0f * r * r * (pBall - pLiq) / n * 9.82f);
                NewY = -1 * (v0 * Convert.ToSingle(Math.Exp(-1 * alpha * time)) + geff / alpha * (1 - Convert.ToSingle(Math.Exp(-1 * alpha * time))));
                //print("NewY: " + NewY + "\n");
                ball.velocity = new Vector2(0, NewY);
            }
            catch (Exception e) {}
        }
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
