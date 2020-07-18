using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoBall : MonoBehaviour
{

    public Dropdown dropdown;
    public int pBall;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (dropdown.value)
        {
            case 0:
                text.text = "Материал шара, ρ=11300 кг/m^3";
                pBall = 11300;
                break;
            case 1:
                text.text = "Материал шара, ρ=7800 кг/m^3";
                pBall = 7800;
                break;
            case 2:
                text.text = "Материал шара, ρ=7000 кг/m^3";
                pBall = 7000;
                break;
            case 3:
                text.text = "Материал шара, ρ=2700 кг/m^3";
                pBall = 2700;
                break;
        }
    }
}
